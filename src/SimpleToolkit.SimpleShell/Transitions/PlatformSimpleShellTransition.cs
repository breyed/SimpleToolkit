﻿namespace SimpleToolkit.SimpleShell.Transitions;

public class PlatformSimpleShellTransition : ISimpleShellTransition
{
#if ANDROID
    public Func<SimpleShellTransitionArgs, bool> DestinationPageInFrontOnSwitching { get; init; }
    public Func<SimpleShellTransitionArgs, int> SwitchingEnterAnimation { get; init; }
    public Func<SimpleShellTransitionArgs, int> SwitchingLeaveAnimation { get; init; }
    public Func<SimpleShellTransitionArgs, int> PushingEnterAnimation { get; init; }
    public Func<SimpleShellTransitionArgs, int> PushingLeaveAnimation { get; init; }
    public Func<SimpleShellTransitionArgs, int> PoppingEnterAnimation { get; init; }
    public Func<SimpleShellTransitionArgs, int> PoppingLeaveAnimation { get; init; }

    public PlatformSimpleShellTransition()
	{
	}
#elif IOS || MACCATALYST
    public delegate void TransitionAnimation(UIKit.UIView from, UIKit.UIView to);

    public Func<SimpleShellTransitionArgs, bool> DestinationPageInFrontOnSwitching { get; init; }
    public Func<SimpleShellTransitionArgs, TransitionAnimation> SwitchingAnimation { get; init; }
    public Func<SimpleShellTransitionArgs, TransitionAnimation> SwitchingAnimationStarting { get; init; }
    public Func<SimpleShellTransitionArgs, TransitionAnimation> SwitchingAnimationFinished { get; init; }

    public PlatformSimpleShellTransition()
	{
	}
#elif WINDOWS
	public PlatformSimpleShellTransition()
	{
	}
#endif
}