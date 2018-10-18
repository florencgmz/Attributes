using ExampleAttributes.Attributes;

namespace ExampleAttributes.Enums
{
    public enum Fruit
    {
        [DisplayNameAttribute("Lemon")]
        Lemon,
        [DisplayNameAttribute("Watermelon")]
        Watermelon,
        [DisplayNameAttribute("Orange")]
        Orange,
        [DisplayNameAttribute("BloodOrange")]
        BloodOrange,
        [DisplayNameAttribute("Kiwi")]
        Kiwi,
        [DisplayNameAttribute("Banana")]
        Banana
    }
}