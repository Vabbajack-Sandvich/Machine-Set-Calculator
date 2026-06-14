![example 1](https://github.com/Vabbajack-Sandvich/Machine-Set-Calculator/blob/main/machine-set-calculator-1.png?raw=true)

# Machine Set Calculator

TLDR0: Sets every machine in the blueprint to 100% efficiency based on input ppm by copy and pasting the same percent in to every machine.

TLDR1: Makes it easy to adjust for new inputs or upgrades by placing the same blueprint and changing the number of machines in the calculator and hitting enter.

TLDR2: Hitting enter while the cursor is in the text boxes will automatically calculate and copy the resulting percentage to the clipboard for easy pasting in the game.

=================================

You can use input or output parts per minute, because you can make changes to machine sets based on either of those.

Typically, you use input parts per minute for 1 single machine recipe.

This tells you, based on the output percent, how much you need to overclock or underclock every machine in a set.

If it's above 250%, you need more machines.

If it's below 100%, you need fewer machines. In either case, you set all of the machines to the output percent.

This makes the total throughput equal the new input.

To check to see what I mean:

Set one machine to the output percent, then multiply its new parts per minute value by the number of machines.

You would see it equals the new desired input/output value.

=================================

# Windows Scaling Issue Fix:

This is a Windows issue and not a program issue.

=================================

Right-click the exe or shortcut.

Click properties.

Click the compatibility tab.

Click Change High DPI Settings.

Check the "Use this setting to fix scaling problems" check box.

Set the drop-down box to "when I signed in to Windows."

Check the "override high DPI scaling behavior."

Select "application" from the drop-down box.

Click ok, click ok, start the program to check to see if it fixed it.

=================================

This is a stand alone simple calculator instead of a mod. Mods have to the potential to break because of updates, be abandoned etc etc etc. So, because of that, I made a simple stand alone calculator that you can alt tab to.

=================================

I will fix errors.

I don't plan on maintaining this past it's usefulness.

I don't plan on helping people with problems.

I don't plan on making a tutorial video.

I thought this was a useful tool for calculating machine through put that would be valulable to others so I'm sharing it.

=================================

This calculates throughput like this:

=================================

p = individual machine parts per minute number

n = number of machines in the set

b = the total output of all the machines at the base parts per minute number which gets calculated automatically

d = desired new input intended to be put through all the machines

o = output percent to set each machine in the set to

=================================

b = p * n

o = (d / b) * 100

