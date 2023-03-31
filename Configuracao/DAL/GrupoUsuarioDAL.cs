﻿using Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace DAL
{
    public class GrupoUsuarioDAL
    {
        public void Inserir(GrupoUsuario _grupoUsuario)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"INSERT INTO GrupoUsuario(NomeGrupo) VALUES (@NomeGrupo)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeGrupo", _grupoUsuario.NomeGrupo);

                cn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir o nome do grupo no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(GrupoUsuario _grupoUsuario)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"UPDATE GrupoUsuario SET NomeGrupo = @NomeGrupo WHERE ID = @ID";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeGrupo", _grupoUsuario.NomeGrupo);
                cmd.Parameters.AddWithValue("@ID", _grupoUsuario.IdGrupoUser);

                cn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar o nome do grupo no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int _id, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM GrupoUsuario WHERE ID = @ID", cn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@ID", _id);
                    try
                    {
                        if (_transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }

                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        RemoverTodasPermissoes(_id, transaction);
                        RemoverTodosUsuarios(_id, transaction);
                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();

                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar excluir o grupo de usuário no banco: " + ex.Message);
                    }
                }
            }
        }
        private void RemoverTodasPermissoes(int _id, SqlTransaction _transaction)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM PermissaoGrupoUsuario WHERE ID_GrupoUsuario = @ID_GrupoUsuario", cn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@ID_GrupoUsuario", _id);
                    try
                    {
                        if (_transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }

                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();

                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar excluir todas as permissões do grupo no banco: " + ex.Message);
                    }
                }
            }
        }
        private void RemoverTodosUsuarios(int _id, SqlTransaction _transaction)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM UsuarioGrupoUsuario WHERE ID_GrupoUsuario = @ID_GrupoUsuario", cn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@ID_GrupoUsuario", _id);
                    try
                    {
                        if (_transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }

                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();

                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar excluir todos os usuários do grupo no banco de dados: " + ex.Message);
                    }
                }
            }
        }
        public GrupoUsuario BuscarGrupoPorNome(string _nome)
        {
            GrupoUsuario grupousuario = new GrupoUsuario();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = "SELECT ID, NomeGrupo FROM GrupoUsuario WHERE NomeGrupo = @NomeDoGrupo";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeDoGrupo", _nome);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        grupousuario = new GrupoUsuario();
                        grupousuario.IdGrupoUser = Convert.ToInt32(rd["ID"]);
                        grupousuario.NomeGrupo = rd["NomeGrupo"].ToString();


                    }
                    else
                    {
                        throw new Exception("Grupo de Usuário não encontrado.");
                    }
                    return grupousuario;

                }
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar todos os grupos de usuários: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<GrupoUsuario> BuscarPorIdGrupo(int _idGrupo)
        {
            List<GrupoUsuario> listaGruposUsuario = new List<GrupoUsuario>();
            GrupoUsuario grupoUsuario = new GrupoUsuario();

            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT TOP 100 ID, NomeGrupoUsuario FROM GrupoUsuario WHERE ID = @ID";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", _idGrupo);

                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    grupoUsuario = new GrupoUsuario();
                    grupoUsuario.IdGrupoUser = Convert.ToInt32(dr["ID"]);
                    grupoUsuario.NomeGrupo = dr["NomeGrupo"].ToString();
                    listaGruposUsuario.Add(grupoUsuario);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o grupo de usuário no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return listaGruposUsuario;
        }
        public List<GrupoUsuario> ExibirTodosGrupos()
        {
            SqlConnection cn = new SqlConnection();
            List<GrupoUsuario> listaGruposUsuario = new List<GrupoUsuario>();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT * FROM GrupoUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    GrupoUsuario grupoUsuario = new GrupoUsuario();
                    grupoUsuario.IdGrupoUser = Convert.ToInt32(dr["ID"]);
                    grupoUsuario.NomeGrupo = dr["NomeGrupo"].ToString();
                    listaGruposUsuario.Add(grupoUsuario);
                }

                return listaGruposUsuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os grupos de usuários no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void ExcluirRelacioGrupoPermissao(int _idgrupo, int _idpermissao)
        {
            SqlConnection cn = new SqlConnection();
            try
            {

                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "DELETE FROM PermissaoGrupoUsuario WHERE ID_GrupoUsuario = @idgrupo AND ID_Permissao = @idpermissao";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@idgrupo", _idgrupo);
                cmd.Parameters.AddWithValue("@idpermissao", _idpermissao);


                cn.Open();
                cmd.ExecuteScalar();


            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um relacionamento no banco " + ex.Message);


            }
            finally
            {
                cn.Close();
            }
        }
        public bool ExisteRelacion_GrupoUsuario(GrupoUsuario _idGrupo)
        {
            GrupoUsuario grupoUsuario = new GrupoUsuario();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT 1 AS retorno FROM UsuarioGrupoUsuario WHERE ID_GrupoUsuario = @idGrupo ";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@idGrupo", _idGrupo.IdGrupoUser);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar um relacionamento no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void VincularPermissaoGrupo(int _idPermissao, int _idGrupo)
        {
            SqlConnection cn = new SqlConnection();
            try
            {

                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "INSERT INTO PermissaoGrupoUsuario(ID_Permissao, ID_GrupoUsuario)" +
                                  "VALUES (@idPermissao, @idGrupo)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@idPermissao", _idPermissao);
                cmd.Parameters.AddWithValue("@idGrupo", _idGrupo);



                cn.Open();
                cmd.ExecuteScalar();


            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar vincular uma permissão no banco " + ex.Message);


            }
            finally
            {
                cn.Close();
            }

        }
    }
}
