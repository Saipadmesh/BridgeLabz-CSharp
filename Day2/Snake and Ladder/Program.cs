namespace FirstProject
{
    class Player
    {
        public string Name { get; set; }
        public bool Win;
        private int _Pos;

        public Player(string name)
        {
            Name = name;
            Win = false;
            _Pos = 0;
        }

        public void Move(int steps, int direction)
        {
            
            int totalSteps = steps * direction;
            if(_Pos+totalSteps<0)
            {
                _Pos = 0;
            }
            else if(_Pos+totalSteps<=100) {
                _Pos += totalSteps;
                Console.WriteLine("{0} has moved to {1}",Name, _Pos);
            }
            if(_Pos == 100)
            {
                Win = true;
                Console.WriteLine("Player {0} has won the game", Name);
            }

        }
    }
    internal class Program
    {
        static int RollDie()
        {
            Random r = new Random();
            return r.Next(1,7);
        }

        static int GetDirection()
        {
            Random r = new Random();
            int type = r.Next(0, 3);
            return (type == 2) ? -1 : type;
        }
        static void Main(string[] args)
        {
            var P1 = new Player("P1");
            var P2 = new Player("P2");
            int currPlayer = 0;
            while(!P1.Win && !P2.Win)
            {
                if(currPlayer == 0)
                {
                    
                    int steps = RollDie(), direction = GetDirection();
                    P1.Move(steps,direction);
                    if(direction>0 || P1.Win)
                    {
                        continue;
                    }
                    
                    else
                    {
                        currPlayer++;
                    }
                }
                else if (currPlayer == 1)
                {

                    int steps = RollDie(), direction = GetDirection();
                    P2.Move(steps, direction);
                    if (direction > 0 || P2.Win)
                    {
                        continue;
                    }
                    
                    else
                    {
                        currPlayer--;
                    }
                }

            }



        }
    }
}