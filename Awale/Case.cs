using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Awale
{
    class Case
    {
        private int nbGraines;
        private int position;
        private String path;

        public int NbGraines { get => nbGraines; set => nbGraines = value; }
        public int Position { get => position; set => position = value; }
        public string Path { get => path; set => path = value; }

        public Case(int nbGraines, int position, string path)
        {
            this.nbGraines = nbGraines;
            this.position = position;
            this.path = path;
        }
    }
}
