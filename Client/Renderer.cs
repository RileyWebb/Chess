using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using Chess;

namespace Client
{
    public class Renderer
    {
        public Client Client;
        public Window Window;
        
        public Rectangle Viewport;
        public Graphics Graphics;
        public BufferedGraphics Buffer;

        private Bitmap _board;
        
        public Renderer(Client client)
        {
            //DRAW BOARD AND SCALE ON EACH FRAME

            Client = client;
            Window = client.Window;
            
            Window.ClientSizeChanged += (sender, e) => Resize(Window.ClientRectangle);
            Resize(Window.ClientRectangle);
        }

        public void Render()
        {
            //_buffer.Graphics.Clear(Color.Black);
            
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

        public void DrawPiece(Piece piece, int x, int y)
        {
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
        }
        /*
        Viewport = viewport;
        
        Buffer = BufferedGraphicsManager.Current.Allocate(_graphics, _viewport);
        
        Buffer.Graphics.CompositingMode = CompositingMode.SourceCopy;
        Buffer.Graphics.CompositingQuality = CompositingQuality.AssumeLinear;
        Buffer.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
        Buffer.Graphics.SmoothingMode = SmoothingMode.None;
        Buffer.Graphics.PixelOffsetMode = PixelOffsetMode.Half;

        _board = DrawBoard(Viewport.Size);
        for (int x = 0; x < _game.Board.Width; x++)
        for (int y = 0; y < _game.Board.Height; y++)
        {
            Color c;

            if ((y % 2 == 0 ? 1 : 0) + x % 2 == 1)
                c = _colorOdd;
            else
                c = _colorEven;
        }
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
                
                if ((y % 2 == 0 ? 1 : 0) + x % 2 == 1)
                
                data[0] = ;
                data[1] = ;
                data[2] = ;
                data[3] = 255;
            }
        }

        bitmap.UnlockBits(bData);
    } */
    }
}