using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ObserverAndMediator
{
    public class GoalEventArgs : EventArgs
    {
        public string Team { get; set; } = default!;
    }
    public class DotNetServer
    {
        ////automatic property
        //public string Name { get; set; }

        ////property
        //private string _name2;
        //public string Name2
        //{
        //    get { return _name2; }
        //    set { _name2 = value; }
        //}

        // ...

        // kind of the same -- automatic -- normally is the one use 99% of time
        public event EventHandler<GoalEventArgs>? Goal;
        //// manually -- there might be situations in which is better -- in crazily complex project !!😂
        //private EventHandler<GoalEventArgs> _goal2;
        //public event EventHandler<GoalEventArgs>? Goal2
        //{
        //    add
        //    {
        //        _goal2 += value;
        //    }
        //    remove
        //    {
        //        _goal2 -= value;
        //    }
        //}

        public void TellThemAboutTheGoal(string team)
        {
            Goal?.Invoke(this, new GoalEventArgs { Team = team });
        }
        
    }

    public class DotNetClient
    {
        private readonly DotNetServer _server;

        public DotNetClient(DotNetServer s)
        {
            this._server = s;
            // to complete...
            _server.Goal += _server_Goal;
            //_server.Goal -= _server_Goal;
        }    

        private void _server_Goal(object? sender, GoalEventArgs e)
        {
            Console.WriteLine($"goal for {e.Team}");
        }

    }
}
