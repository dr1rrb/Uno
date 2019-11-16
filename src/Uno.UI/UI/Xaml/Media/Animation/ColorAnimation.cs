#if __WASM__
namespace Windows.UI.Xaml.Media.Animation
{
	public partial class ColorAnimation : Timeline, ITimeline
	{
		public ColorAnimation() : base()
		{
		}
			   
		public Color? From
		{
			get => (Color?)this.GetValue(FromProperty);
			set => this.SetValue(FromProperty, value);
		}

		public static DependencyProperty FromProperty { get; } =
			DependencyProperty.Register(
				"From", typeof(Color?),
				typeof(ColorAnimation),
				new FrameworkPropertyMetadata(default(Color?)));

		public Color? To
		{
			get => (Color?)this.GetValue(ToProperty);
			set => this.SetValue(ToProperty, value);
		}

		public static DependencyProperty ToProperty { get; } =
			DependencyProperty.Register(
				"To", typeof(Color?),
				typeof(ColorAnimation),
				new FrameworkPropertyMetadata(default(Color?)));

		public Color? By
		{
			get => (Color?)this.GetValue(ByProperty);
			set => this.SetValue(ByProperty, value);
		}

		public static readonly DependencyProperty ByProperty =
			DependencyProperty.Register(nameof(By), typeof(Color?),
				typeof(ColorAnimation), new PropertyMetadata(null));

		public bool EnableDependentAnimation
		{
			get => (bool)this.GetValue(EnableDependentAnimationProperty);
			set => this.SetValue(EnableDependentAnimationProperty, value);
		}
		
		public static DependencyProperty EnableDependentAnimationProperty { get; } =
			DependencyProperty.Register(
				nameof(EnableDependentAnimation), typeof(bool),
				typeof(ColorAnimation),
				new FrameworkPropertyMetadata(default(bool)));

		public EasingFunctionBase EasingFunction
		{
			get => (EasingFunctionBase)this.GetValue(EasingFunctionProperty);
			set => this.SetValue(EasingFunctionProperty, value);
		}

		public static DependencyProperty EasingFunctionProperty { get; } =
			DependencyProperty.Register(nameof(EasingFunction), typeof(EasingFunctionBase),
				typeof(ColorAnimation), new FrameworkPropertyMetadata(default(EasingFunctionBase)));
	}
}
#endif
