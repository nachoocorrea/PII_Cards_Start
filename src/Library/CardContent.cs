//------------------------------------------------------------------------------
// <copyright file="CardContent.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

namespace Ucu.Poo.Cards
{
    /// <summary>
    /// Representa un naipe de póker.
    /// </summary>
    public abstract class CardContent
    {
        /// <summary>
        /// Obtiene el valor del naipe.
        /// </summary>
        public virtual Rank Rank { get; protected set; }

        /// <summary>
        /// Obtiene el palo del naipe.
        /// </summary>
        public virtual Suit Suit { get; protected set; }

        /// <summary>
        /// Obtiene el texto para imprimir el naipe.
        /// </summary>
        /// <returns>El texto del naipe.</returns>
        public virtual string GetTextToPrint()
        {
            switch (this.Suit)
            {
                case Suit.Hearts:
                    return $"♥ {this.Rank}";
                case Suit.Diamonds:
                    return $"♦ {this.Rank}";
                case Suit.Clubs:
                    return $"♣ {this.Rank}";
                default:
                    return $"♠ {this.Rank}";
            }
        }
    }
}