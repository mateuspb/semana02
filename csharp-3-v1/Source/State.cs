using System;

namespace Codenation.Challenge
{
    public class State
    {
        public State(string name, string acronym)
        {
            this.Name = name;
            this.Acronym = acronym;
        }
        public State(string name, string acronym, double extension)
        {
            this.Name = name;
            this.Acronym = acronym;
            this.Extension = extension;
        }
        public string Name { get; set; }

        public string Acronym { get; set; }

        public double Extension { get; set; }
    }

}
