namespace ACT2CreateThreeObjects
{
    public class Card
    {
        private const string PosibleCardType = "HPCD";
        private const string PosibleCardValue = "A23456789JQK";
        private const string WrongCardType = "The assigned card type is wrong";
        private const string WrongCardValue = "The assigned card value is wrong";
        private char cardType;
        private char cardValue;
        private float width;
        private float height;

        public Card(char cardType, char cardValue)
        {
            CardType = cardType;
            CardValue = cardValue;
        }
        public Card(char cardType, char cardValue, float width, float height) : this(cardType, cardValue)
        {
            Width = width;
            Height = height;
        }

        public char CardType
        {
            get => cardType;
            set
            {
                if (!ValidateCardType(value))
                {
                    throw new Exception(WrongCardType);
                }
                cardType = value;
            }
        }
        public char CardValue
        {
            get => cardValue;
            set
            {
                if (!ValidateCardValue(value))
                {
                    throw new Exception(WrongCardValue);
                }
                cardValue = value;
            }
        }
        public float Width
        {
            get => width;
            set => width = value;
        }
        public float Height
        {
            get => height;
            set => height = value;
        }
        public static bool ValidateCardType(char cardType)
        {
            char[] cardTypes = PosibleCardType.ToCharArray();
            for (int i = 0; i < cardTypes.Length; i++)
            {
                if (cardTypes[i] == cardType) return true;
            }
            return false;
        }
        public static bool ValidateCardValue(char cardValue)
        {
            char[] cardValues = PosibleCardValue.ToCharArray();
            for (int i = 0; i < cardValues.Length; i++)
            {
                if (cardValues[i] == cardValue) return true;
            }
            return false;
        }
    }
}

