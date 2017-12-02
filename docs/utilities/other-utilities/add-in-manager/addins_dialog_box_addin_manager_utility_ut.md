---
title: Add-In Manager Dialog Box
---

# Add-In Manager Dialog Box


Use the **Add-In Manager** dialog  box to manage the **Everest Add-Ins**  installed and registered on each workstation. You can view, enable, disable,  configure, and remove selected add-ins.


The **Add-In Manager** dialog box  contains a list of registered add-ins. Each row contains information on  one add-in.


**Registered Add-Ins**
: This column displays a list of add-ins registered  on the workstation. The add-in names come from the add-in configuration  file.


**Status**
: This column displays the current status of the add-in.  Valid values include the following:

- **Enabled**  – The add-in is activated on this machine and is ready for use.
- **Disabled**  – The add-in is not in operation on this machine and cannot be used.
- **Not 
 Responding** – There is a problem with this add-in. You can try restarting  **Everest** to resolve this issue.  If this status does not change after restarting **Everest**,  contact your add-in provider for additional assistance.



Details


**Objects**
: The top portion of the **Details**  section displays the object names from the add-in configuration file of  the selected add-in.


**Description**
: The lower portion of the **Details**  section displays the description of the add-in from the add-in configuration  file of the selected add-in.


****The following 
 buttons are available in the** Add-In Manager **dialog box:****


**Enable**
: Click the **Enable**  button to activate the selected add-in on this workstation. An add-in  must be enabled before it can be used on the workstation.


**Disable**
: Click the **Disable**  button to turn off the add-in on this workstation. Disable an add-in if  you do not want it to be used on this workstation. You can activate it  again, if necessary.


**Remove**
: Click the **Remove**  button to remove the add-in from the Add-In Manager list so that it cannot  be enabled. The configuration file extension is renamed from ACF to BAK.  Do not select this option if you only want to remove the add-in temporarily  since the add-in file configuration file extension is renamed. If you  want to remove the add-in temporarily, use the **Disable**  option instead.


**Options**
: Click the **Options**  button to view any configurations specific to the selected add-in. Your  add-in provider may make additional configuration selections available  using this option. The **Options**  button is disabled when the add-in is disabled.


**Close**
: Click the **Close**  button to exit the **Add-In Manager**  utility.


{:.see_also}
See also
: [Add-In Manager  Utility]({{site.utl_baseurl}}/other-utilities/add-in-manager/addin_manager_utility_ut.html)
