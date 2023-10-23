using System.Reflection.Metadata.Ecma335;

namespace GameOfLifeLibrary
{
    public class GameOfLife
    {
        public const int cellWidth = 0;
        public const int cellHeight = 0;

        private int width,
                    height;
        private List<Cell> cells = new List<Cell>(0);

        GameOfLife() { }

        public void Start() { 
            Draw();
            Update();
        }

        public void End() { }

        public void Update() { }
        public void Draw() { }
    }
}