using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverAndMediator
{
    public class Server
    {
        public interface IFootBallEvents
        {
            void Goal(string team)
            {

            }
        }

        private List<IFootBallEvents> subscribers = new List<IFootBallEvents>();    
        public void Register(IFootBallEvents ev)
        {
            subscribers.Add(ev);
        }
        public void Unregister(IFootBallEvents ev)
        {
            subscribers.Remove(ev);
        }

        public void TellThemAboutTheGoal(string team)
        {
            foreach (IFootBallEvents ev in subscribers)
                ev.Goal(team);
        }

    }

    public class Client : Server.IFootBallEvents

    {
        private readonly Server _server;

        public Client(Server server)
        {
            _server = server;
            _server.Register(this);
        }

        public void Goal(string team)
        {
            Console.WriteLine($"goal for {team}");
        }
    }
}
