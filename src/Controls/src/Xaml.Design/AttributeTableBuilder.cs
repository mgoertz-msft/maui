using System;
using System.ComponentModel;
using Microsoft.Windows.Design;

namespace Microsoft.Maui.Controls.Xaml.Design
{
	class AttributeTableBuilder : Microsoft.Windows.Design.Metadata.AttributeTableBuilder
	{
		public AttributeTableBuilder()
		{
			AddCustomAttributes(typeof(ArrayExtension).Assembly,
				new XmlnsSupportsValidationAttribute("http://schemas.microsoft.com/dotnet/2021/maui", false));

			AddCallback(typeof(OnPlatformExtension), builder => builder.AddCustomAttributes(new Attribute[] {
				new System.Windows.Markup.MarkupExtensionReturnTypeAttribute (),
			}));
			AddCallback(typeof(OnIdiomExtension), builder => builder.AddCustomAttributes(new Attribute[] {
				new System.Windows.Markup.MarkupExtensionReturnTypeAttribute (),
			}));
		}
	}
}