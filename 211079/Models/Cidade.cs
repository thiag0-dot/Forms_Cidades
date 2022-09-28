using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace _211079.Models
{
    internal class Cidade
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Uf { get; set; }
    }
}
