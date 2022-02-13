using System;

namespace ChessGame.Models
{
    public class Piece
    {
        private bool _isWhite = false;
        private bool _isKilled = false;
        public Piece(bool isWhite)
        {
            this.SetWhite(isWhite);
        }

        public void SetWhite(bool isWhite)
        {
            this._isWhite = isWhite;
        }

        public void SetKilled(bool isKilled)
        {
            this._isKilled = isKilled;
        }

        public virtual bool CanMove(Piece p, Box start, Box end)
        {
            return true;
        }
    }
}
