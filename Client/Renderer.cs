using System.Drawing;

namespace Client
{
    public class Renderer
    {
        public Renderer(Client client)
        {
            //DRAW BOARD AND SCALE ON EACH FRAME
            
            //window.ClientSizeChanged += (sender, e) => Resize(window.ClientRectangle);
            //Resize(window.ClientRectangle);
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
            //_viewport = viewport;
            
            //_buffer = BufferedGraphicsManager.Current.Allocate(_graphics, _viewport);
            
            //_buffer.Graphics.CompositingMode = CompositingMode.SourceCopy;
            //_buffer.Graphics.CompositingQuality = CompositingQuality.AssumeLinear;
            //_buffer.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            //_buffer.Graphics.SmoothingMode = SmoothingMode.None;
            //_buffer.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
        }
    }
}