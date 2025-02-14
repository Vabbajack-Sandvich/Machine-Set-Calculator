# Machine Set Calculator

TLDR: This makes it easy to change the numbers around until you get the percent you want.

TLDR2: Hitting enter while the cursor is in the text boxes will automatically calculate and copy the resulting percentage to the clipboard for easy pasting in the game.

TLDR3:

you can use input or output parts per minute, because you can make changes to machine sets based on either of those

typically you use input parts per minute for 1 single machine recipe

this tells you, based on the output percent how much you need to overclock or underclock every machine in a set

if its above 250% you need more machines

if its way below 100% you need less machines


=================================

Windows Scaling Issue Fix:

This is a Windows issue and not a program issue.

=================================


right click the exe or shortcut

click properties

click the compatability tab

click change high dpi settings

check the "use this setting to fix scaling problems" check box

set the drop down box to "when i signed in to windows"

check the "override high dpi scaling behavior"

select "application" from the drop down box

click ok, click ok, start the program to check to see if it fixed it



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
