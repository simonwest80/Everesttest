---
title: Multiple Account Creation Wizard - Segment Selection Range
---
<script type="text/javascript" language="JavaScript1.2" x-save-method="compute-relative" src="{{site.sc_baseurl}}/misc/ehlpdhtm.js"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
Enter the **Short Name** of the  segment for which you are creating values.

Enter the range of values to create for this segment. The value in the  **End Range** field must be the same  number of characters or greater than the **Start 
 Range** field.

Enter the Increments that you want to specify between your accounts.  The default increment is 10 but you can enter up to 3 characters, such  as 1, 5, 10, or 100.

If you would like to enter a prefix for the range of accounts you are  creating, enter the prefix in this field. For example, if you add A for  a prefix, your accounts can be A001 and A002.

Enter the fixed **Description**  that will appear for every account created. It precedes the values entered  in the range. For example, if you enter SUB in the **Description**  field and your range is 001-002, your accounts display as SUB 001 and  SUB 002.

Select this option to select an actual account code as the parent account  of the accounts being created.

If the **Define Parent Account**  option is selected, this field is enabled. Select an actual account from  the drop-down list to use as the Parent Account.

This field displays the description for the **Parent 
 Account Code** selected.

Select this option to generate parent accounts based on the segments  used. If the **Define Parent Account Using 
 Above Hierarchy** option is selected, this field is enabled. Select  a previously defined segment from the drop-down list.

# Multiple Account Creation Wizard - Segment Selection Range


Use this section to create a range of accounts. A line appears for each  segment in your segment format.


Segments must be created in hierarchical order.

- Enter or select information for the following  fields. Click on the links for field details.



{:.example}
: If the segment format is DIV-DEP-SUB (Division,  Department, Sub-department), then DIV must be created before DIV-DEP and  DIV-DEP must be created before DIV-DEP-SUB.
: Segment Selection Range Grid
: [Short Name](javascript:kadovTextPopup(this)){:id="a4"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a4');
//--></script>
: [Start/End Range](javascript:kadovTextPopup(this)){:id="a5"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a5');
//--></script>
: [Increment](javascript:kadovTextPopup(this)){:id="a6"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a6');
//--></script>
: [Prefix](javascript:kadovTextPopup(this)){:id="a7"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a7');
//--></script>


{:.note}
: The number of characters in the **Prefix**  field plus the number of characters  in the **Range** field cannot be more  than the segment length.


{:.example}
: If you have a segment length of 5, and there are  3 characters in the range, then the prefix can be 1 or 2 characters.
: [Description](javascript:kadovTextPopup(this)){:id="a8"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a8');
//--></script>
: [Define Parent Account](javascript:kadovTextPopup(this)){:id="a11"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a11');
//--></script>
: [Parent Account Code](javascript:kadovTextPopup(this)){:id="a12"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a12');
//--></script>


{:.note}
: When creating the first segment, one of the five  base accounts must be selected. For example:


| Base Account | Description |
| A | Asset |
| L | Liability |
| C | Capital |
| R | Revenue |
| E | Expense |

: [Parent Account Description](javascript:kadovTextPopup(this)){:id="a13"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a13');
//--></script>
: Define Parent Account Using Above Hierachy
: Define parent accounts for the remaining segments  after creating parent accounts for the first segment.
: [Define parent account using above hierarchy](javascript:kadovTextPopup(this)){:id="a9"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a9');
//--></script>


{:.steps}
Once you have entered the necessary information  to set up your accounts, do the following:

- Click **Preview**  to preview the accounts to be created. The **Multiple Account** **Browser** is displayed.



![]({{site.sc_baseurl}}/img/see_also.gif)
: [Multiple  Account Browser]({{site.sc_baseurl}}/misc/multiple_account_browser_macw_sc.html)
: [Custom Chart  of Accounts]({{site.sc_baseurl}}/misc/custom_chart_of_accounts.html)
: [Create  Multiple Accounts]({{site.sc_baseurl}}/options/acc-info/coa/setup-coa/create_multiple_accounts_multiple_accounts_creation_wizard.html)
