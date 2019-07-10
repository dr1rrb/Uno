using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;
using Windows.Foundation;
using Uno.Extensions;

namespace Uno.UI.Tests.RelativePanelTests
{
	[TestClass]
	public class Given_RelativePanel : Context
	{
		[TestMethod]
		public void When_Empty_And_MeasuredEmpty()
		{
			var SUT = new RelativePanel() { Name = "test" };

			SUT.Measure(default(Size));
			SUT.Arrange(default(Rect));

			Assert.AreEqual(default(Size), SUT.DesiredSize);
			Assert.IsTrue(SUT.GetChildren().None());
		}

[TestMethod]
public void When_Child_Aligns_Horizontal_Center_With_Panel()
{
	var SUT = new RelativePanel()
	{
		Name = "test",
		Width = 1000,
		Height = 1000
	};
	var border = new MeasuredControl(new Size(100, 100));
	border.SetValue(RelativePanel.AlignHorizontalCenterWithPanelProperty, true);

	SUT.Children.Add(border);

	SUT.Measure(new Size(1000, 1000));
	SUT.Arrange(new Rect(0, 0, 1000, 1000));

	Assert.AreEqual(new Rect(450, 0, 100, 100), border.Arranged);
}

[TestMethod]
public void When_Child_Aligns_Vertical_Center_With_Panel()
{
	var SUT = new RelativePanel()
	{
		Name = "test",
		Width = 1000,
		Height = 1000
	};
	var border = new MeasuredControl(new Size(100,100));
	border.SetValue(RelativePanel.AlignVerticalCenterWithPanelProperty, true);

	SUT.Children.Add(border);

	SUT.Measure(new Size(1000, 1000));
	SUT.Arrange(new Rect(0, 0, 1000, 1000));

	Assert.AreEqual(new Rect(0, 450, 100, 100), border.Arranged);
}

		[TestMethod]
		public void When_Child_Aligns_Horizontal_Center_With_Panel_With_Specific_Size()
		{
			var SUT = new RelativePanel()
			{
				Name = "test",
				Width = 1000,
				Height = 1000
			};
			var border = new Border(){Width = 100, Height = 100};
			border.SetValue(RelativePanel.AlignHorizontalCenterWithPanelProperty, true);

			SUT.Children.Add(border);

			SUT.Measure(new Size(1000, 1000));
			SUT.Arrange(new Rect(0, 0, 1000, 1000));

			Assert.AreEqual(new Rect(450, 0, 100, 100), border.Arranged);
		}

/// <summary>
/// Test control which returns a specifc size from MeasureOverride
/// </summary>
private class MeasuredControl : Control
{
	private readonly Size _measureSize;

	public MeasuredControl(Size measureSize)
	{
		_measureSize = measureSize;
	}

	protected override Size MeasureOverride(Size availableSize) => _measureSize;
}
	}
}
