using System;
using System.Collections.Generic;

namespace dreamteam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IStudent> ClientSide = new List<IStudent>();
            List<IStudent> ServerSide = new List<IStudent>();

            Austin austin = new Austin();
            Jordan jordan = new Jordan();
            Jacob jacob = new Jacob();
            Brett brett = new Brett();
            Evan evan = new Evan();
            Jenn jenn = new Jenn();

            ClientSide.Add(austin);
            ClientSide.Add(jordan);
            ServerSide.Add(jacob);
            ClientSide.Add(brett);
            ServerSide.Add(evan);
            ClientSide.Add(jenn);

            foreach (IStudent student in ClientSide)
            {
                student.Work();
            }

            foreach (IStudent student in ServerSide)
            {
                student.Work();
            }

        }
    }
}
