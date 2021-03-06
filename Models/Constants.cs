namespace Tsundoku.Models
{
    public class Constants
    {
        public const ushort CARD_HEIGHT = 290;
		public const ushort CARD_WIDTH = 525;
        public const ushort RIGHT_SIDE_CARD_WIDTH = 355;
        public const ushort LEFT_SIDE_CARD_WIDTH = CARD_WIDTH - RIGHT_SIDE_CARD_WIDTH;
        public const byte BOTTOM_SECTION_CARD_HEIGHT = 40;
        public const ushort TOP_SECTION_CARD_HEIGHT = CARD_HEIGHT - BOTTOM_SECTION_CARD_HEIGHT - 40;
    }
}