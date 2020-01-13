using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml.Input;
using AppKit;
using Uno.UI.Extensions;

namespace Windows.UI.Xaml
{
	partial class UIElement
	{
		public override void MouseEntered(NSEvent evt)
		{
			try
			{
				// evt.AllTouches raises a invalid selector exception
				var args = new PointerRoutedEventArgs(null, evt, this);
				var pointerEventIsHandledInManaged = false;

				pointerEventIsHandledInManaged = OnNativePointerEnter(args);

				if (!pointerEventIsHandledInManaged)
				{
					// Bubble up the event natively
					base.MouseEntered(evt);
				}
			}
			catch (Exception e)
			{
				Application.Current.RaiseRecoverableUnhandledException(e);
			}
		}

		public override void MouseMoved(NSEvent evt)
		{
			try
			{
				// evt.AllTouches raises a invalid selector exception
				var args = new PointerRoutedEventArgs(null, evt, this);
				var pointerEventIsHandledInManaged = false;

				pointerEventIsHandledInManaged = OnNativePointerMove(args);

				if (!pointerEventIsHandledInManaged)
				{
					// Bubble up the event natively
					base.MouseMoved(evt);
				}
			}
			catch (Exception e)
			{
				Application.Current.RaiseRecoverableUnhandledException(e);
			}
		}

		public override void MouseExited(NSEvent evt)
		{
			try
			{
				// evt.AllTouches raises a invalid selector exception
				var args = new PointerRoutedEventArgs(null, evt, this);
				var pointerEventIsHandledInManaged = false;

				pointerEventIsHandledInManaged = OnNativePointerExited(args);

				if (!pointerEventIsHandledInManaged)
				{
					// Bubble up the event natively
					base.MouseExited(evt);
				}
			}
			catch (Exception e)
			{
				Application.Current.RaiseRecoverableUnhandledException(e);
			}
		}

		public override void MouseDown(NSEvent evt)
		{
			try
			{
				// evt.AllTouches raises a invalid selector exception
				var args = new PointerRoutedEventArgs(null, evt, this);
				var pointerEventIsHandledInManaged = false;

				pointerEventIsHandledInManaged = OnNativePointerDown(args);

				if (!pointerEventIsHandledInManaged)
				{
					// Bubble up the event natively
					base.MouseDown(evt);
				}
			}
			catch (Exception e)
			{
				Application.Current.RaiseRecoverableUnhandledException(e);
			}
		}

		public override void MouseDragged(NSEvent evt) // Moved with left button pressed
		{
			try
			{
				// evt.AllTouches raises a invalid selector exception
				var args = new PointerRoutedEventArgs(null, evt, this);
				var pointerEventIsHandledInManaged = false;

				pointerEventIsHandledInManaged = OnNativePointerMoveWithOverCheck(args, evt.IsTouchInView(this));

				if (!pointerEventIsHandledInManaged)
				{
					// Bubble up the event natively
					base.MouseDragged(evt);
				}
			}
			catch (Exception e)
			{
				Application.Current.RaiseRecoverableUnhandledException(e);
			}
		}

		public override void MouseUp(NSEvent evt)
		{
			try
			{
				// evt.AllTouches raises a invalid selector exception
				var args = new PointerRoutedEventArgs(null, evt, this);
				var pointerEventIsHandledInManaged = false;

				pointerEventIsHandledInManaged = OnNativePointerUp(args);

				if (!pointerEventIsHandledInManaged)
				{
					// Bubble up the event natively
					base.MouseUp(evt);
				}

				IsPointerPressed = false;
				IsPointerOver = false;
			}
			catch (Exception e)
			{
				Application.Current.RaiseRecoverableUnhandledException(e);
			}
		}
	}
}
