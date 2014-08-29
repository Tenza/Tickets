/*
 * Tickets
 * Copyright (C) 2011 Filipe Carvalho
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tickets.Classes
{
    class Utilizador
    {
        private int id;
        private string nome;
        private string email;
        private string telefone;
        private string funcao;
        private string permissao;
        private int id_dep;
        private string nome_dep;

        public Utilizador(int vid, string vnome, string vemail, string vtelefone, string vfuncao, string vpermissao, int vid_dep, string vnome_dep)
        {
            id = vid;
            nome = vnome;
            email = vemail;
            telefone = vtelefone;
            funcao = vfuncao;
            permissao = vpermissao;
            id_dep = vid_dep;
            nome_dep = vnome_dep;
        }

        #region Get / Set
        public int get_id()
        {
            return id;
        }

        public string get_nome()
        {
            return nome;
        }

        public string get_email()
        {
            return email;
        }

        public string get_telefone()
        {
            return telefone;
        }

        public string get_funcao()
        {
            return funcao;
        }

        public string get_permissao()
        {
            return permissao;
        }

        public int get_id_dep()
        {
            return id_dep;
        }

        public string get_nome_dep()
        {
            return nome_dep;
        }

        //--------------------

        public void set_id(int i)
        {
            id = i;
        }

        public void set_nome(string i)
        {
            nome = i;
        }

        public void set_email(string i)
        {
            email = i;
        }

        public void set_telefone(string i)
        {
            telefone = i;
        }

        public void set_funcao(string i)
        {
            funcao = i;
        }

        public void set_permissao(string i)
        {
            permissao = i;
        }

        public void set_id_dep(int i)
        {
            id_dep = i;
        }

        public void set_nome_dep(string i)
        {
            nome_dep = i;
        }
        #endregion

    }
}
