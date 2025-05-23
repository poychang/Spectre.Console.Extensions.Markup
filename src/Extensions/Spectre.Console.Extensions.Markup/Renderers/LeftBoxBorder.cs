using Spectre.Console.Rendering;

namespace Spectre.Console.Extensions.Markup.Renderers;

internal sealed class LeftBoxBorder : BoxBorder
{
    public override string GetPart(BoxBorderPart part)
    {
        if (part is BoxBorderPart.Left)
        {
            return "\u2502";
        }

        return " ";
    }
}