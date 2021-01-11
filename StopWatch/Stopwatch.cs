using System;
using System.Collections.Generic;
using System.Text;

namespace StopWatch
{
    class Stopwatch
    {
        private DateTime _timeStart;
        private DateTime _timeStop;
        private bool _running;

        public void Start()
        {
            _timeStart = DateTime.Now;
            
            if (_running == true)
            {
                throw new System.InvalidOperationException("The timer cannot be started while it is running");
            }
            
            Console.WriteLine("The timer is running");
            
            _running = true;
        }

        public void Stop()
        {
            _timeStart = DateTime.Now;
            
            if (_running == false)
            {
                throw new System.InvalidOperationException("The timer cannot be stopped while it is not running");
            }
            
            _running = false;
            
            Console.WriteLine("The timer has stopped at: " + (_timeStart - _timeStop));
        }
    }
}
