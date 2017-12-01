---
title: Add Segment to Chart of Account Profile
---
<script type="text/javascript" language="JavaScript1.2" x-save-method="compute-relative" src="{{site.sc_baseurl}}/misc/ehlpdhtm.js"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
The **Parent Account Code** field  displays the code for the parent account. It defaults to the selected  account but it can be changed, if necessary.

This **Parent Account Description**  field displays the description of the Parent Account and is a display  only field.

Use the **Account Code** field to  enter characters in the segment being added. For each character in the  segment, a zero (0) defaults in the field. This can be changed, if necessary.

Use the **Account Description**  field to describe the new account being added. Even though it defaults  to the name of the parent account, it can be changed for better clarification.

# Add Segment to Chart of Account Profile


Use the **Chart of Accounts** browser  **Add Segment to Account** menu option  to attach a newly created segment to accounts. You can also add accounts  to previously defined segments that have not yet been used. Only **Detail** accounts can be created using  the **Add Segment to Account** menu  option.


{:.steps}
To add segments to accounts from the Chart  of Accounts browser, do the following:

- From the **Chart 
 of Accounts** browser, highlight the account that needs a segment  and choose **Add Segment to Account**  from the Options menu. The **Add Segment 
 to Account** profile appears.



![]({{site.sc_baseurl}}/img/coa add segment to chart of account main.gif)
: [Parent Account Code](javascript:kadovTextPopup(this)){:id="a1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a1');
//--></script>
: [Parent Account Description](javascript:kadovTextPopup(this)){:id="a2"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a2');
//--></script>
: [Account Code](javascript:kadovTextPopup(this)){:id="a3"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a3');
//--></script>
: [Account Description](javascript:kadovTextPopup(this)){:id="a4"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a4');
//--></script>

- In the **Parent 
 Account Code** field, accept the default selection or change the  account code.
- In the **Account 
 Code** field, accept the default code for the segment being added  or make any necessary changes.
- Update the description in the **Account 
 Description** field.
- Click **Save**  to save your changes and create the new account.



When the new account is created, the original account you selected becomes  a general account and the account balances are transferred to the new  detail account. If there are defaults that use the original account, they  will also change to use the new account. You cannot post to the original  account since it is now a general account.


Click on the following links for specific examples:
: [Add  Segment to Account Profile - Example 1]({{site.sc_baseurl}}/misc/add_segment_to_account_profile_example_1.html)
: [Add  Segment to Account Profile - Example 2]({{site.sc_baseurl}}/misc/add_segment_to_account_profile_-_example_2.html)


![]({{site.sc_baseurl}}/img/see_also.gif)
: [Create  Multiple Accounts]({{site.sc_baseurl}}/options/acc-info/coa/setup-coa/create_multiple_accounts_multiple_accounts_creation_wizard.html)
