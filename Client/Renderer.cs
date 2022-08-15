using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Numerics;
using System.Windows.Forms;
using Chess;
using Svg;

namespace Client
{
    public class Renderer
    {
        public Client Client;
        public Window Window;
        public Game Game;
        
        public Rectangle Viewport;
        public Graphics Graphics;
        public BufferedGraphics Buffer;

        private Bitmap _board;
        private Color _colorOdd = Color.Bisque, _colorEven = Color.SandyBrown;
        
        public Renderer(Window window)
        {
            //DRAW BOARD AND SCALE ON EACH FRAME

            Window = window;
            Client = Window.Client;
            Game = Client.Current;
            Graphics = Window.CreateGraphics();
            
            Window.ClientSizeChanged += (sender, e) => Resize(Window.ClientRectangle);
            Resize(Window.ClientRectangle);
        }

        private static SvgDocument a = SvgDocument.Open("D:\\test.svg");
        
        public void Render()
        {
            Buffer.Graphics.Clear(Color.Black);
            
            Buffer.Graphics.DrawImage(_board, Viewport);

            for (int x = 0; x < Board.Width; x++)
            for (int y = 0; y < Board.Height; y++)
            {
                Buffer.Graphics.CompositingMode = CompositingMode.SourceOver;
                Buffer.Graphics.DrawImage(a.Draw(80, 80), x*80, y*80);
                //Buffer.Graphics.DrawPath(Pens.Black, a.Path);
                Buffer.Graphics.CompositingMode = CompositingMode.SourceCopy;
                //if (Game.Board.Pieces[x, y] != null)
                //DrawPiece(Game.Board.Pieces[x, y], x, y);
            }
            
            Buffer.Render();
            
            /*
            for (int x = 0; x < _game.Board.Width; x++)
            for (int y = 0; y < _game.Board.Height; y++)
            {
                Color c;

                if ((y % 2 == 0 ? 1 : 0) + x % 2 == 1)
                    c = _colorOdd;
                else
                    c = _colorEven;

                _frame.FillRectangle(new SolidBrush(c), x*CellSize, y*CellSize, CellSize, CellSize);

                if (_input.Dragging && _input.HeldPiece.CanMove(x, y))
                    _frame.FillRectangle(new SolidBrush(Color.FromArgb(100,0,175,255)), x*CellSize, y*CellSize, CellSize, CellSize);
                
                if (!(_input.Dragging && _game.Board.Pieces[x, y] == _input.HeldPiece)) // BLINK
                    DrawPiece(_game.Board.Pieces[x, y], x*CellSize, y*CellSize);
            }
            */
            /*
            if (_input.Dragging)
                if (_input.HeldPiece != null)
                    if (_input.HeldPiece.Owner.ID % 2 == 0)
                        _frame.DrawImageUnscaled(_input.HeldPiece.PieceWhite, _input.HeldPosition.X - CellSize/2, _input.HeldPosition.Y - CellSize/2);
                    else
                        _frame.DrawImageUnscaled(_input.HeldPiece.PieceBlack, _input.HeldPosition.X - CellSize/2, _input.HeldPosition.Y - CellSize/2);
            */
            
            //_buffer.Graphics.DrawImageUnscaled(_frameBuffer, 0, 0);

            //_buffer.Graphics.DrawImage(doc.Draw(500, 500),0,0);
            
            
            //_buffer.Render();
        }

        public void DrawPiece(Piece? piece, int x, int y)
        {
            Buffer.Graphics.DrawImage(SvgDocument.Open("D:\\test.svg").Draw(80, 80), x*80, y*80);
            
            //if (piece != null)
                //if (piece.Owner == Game.White)


                    /*
                    if (piece != null)
                        if (piece.Owner.ID % 2 == 0)
                            TextRenderer.DrawText(_frame, piece.Unicode.ToString(), _chessFont, new Rectangle(x,y, 60, 60), Color.White);
                        else
                            TextRenderer.DrawText(_frame, ((char)(piece.Unicode - 6)).ToString(), _chessFont, new Rectangle(x,y, 60, 60), Color.Black, TextFormatFlags.NoPadding | TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter | TextFormatFlags.GlyphOverhangPadding | TextFormatFlags.PreserveGraphicsTranslateTransform);
                            */
        }

        public void Resize(Rectangle viewport)
        {
            
            Viewport = viewport;
            
            Buffer = BufferedGraphicsManager.Current.Allocate(Graphics, Viewport);
            
            Buffer.Graphics.CompositingMode = CompositingMode.SourceCopy;
            Buffer.Graphics.CompositingQuality = CompositingQuality.AssumeLinear;
            Buffer.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            Buffer.Graphics.SmoothingMode = SmoothingMode.None;
            Buffer.Graphics.PixelOffsetMode = PixelOffsetMode.Half;

            _board = DrawBoard(Window.Client.Current?.Board);
        } 
    
        private unsafe Bitmap DrawBoard(Board board)
        {
            Bitmap bitmap = new Bitmap(Board.Width, Board.Height);
            BitmapData bData = bitmap.LockBits(new Rectangle(0, 0, Board.Width, Board.Height), ImageLockMode.ReadWrite, bitmap.PixelFormat);
    
            int bpp = Image.GetPixelFormatSize(bData.PixelFormat);
            byte* scan0 = (byte*)bData.Scan0.ToPointer();
    
            for (int y = 0; y < Board.Width; ++y)
            {
                for (int x = 0; x < Board.Height; ++x)
                {
                    byte* data = scan0 + x * bData.Stride + y * bpp / 8;
                    
                    Color c;
    
                    if ((y % 2 == 0 ? 1 : 0) + x % 2 == 1)
                        c = _colorOdd;
                    else
                        c = _colorEven;
                    
                    data[0] = c.B;
                    data[1] = c.G;
                    data[2] = c.R;
                    data[3] = 255;
                }
            }
    
            bitmap.UnlockBits(bData);

            return bitmap;
        }
    }
}