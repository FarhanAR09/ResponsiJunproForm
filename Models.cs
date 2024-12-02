using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiJunproForm
{
    internal class Karyawan
    {
        public int id_karyawan;
        public string? nama_karyawan;
        public int? id_dep;
        public int? id_jabatan;
    }

    internal class Jabatan
    {
        public int id_jabatan;
        public string? nama_jabatan;
        public float salary;
    }

    internal class Departemen
    {
        public int id_departemen;
        public string? nama_departemen;
    }
}
