---
title: Create the Initial Segment Format
---
<script type="text/javascript" language="JavaScript1.2" x-save-method="compute-relative" src="{{site.sc_baseurl}}/misc/ehlpdhtm.js"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
The **Current Segment Setup** field  is a template for your segment format. As segments are created, this field  automatically populates with the segment short names.


A **Short Name** is an alphanumeric  code that identifies a segment and is limited by the segment length. If  more than one segment is defined, the segments display in position order.


{:.example}
DIV, COMP, and ACCT are short names for the  Division, Company, and Account segments. After these segments are created,  they display in position order as: DIV-COMP-ACCT.

Use this field to enter the number of segments that you are creating.  A line is displayed at the bottom of the **COA 
 Segment Setup** profile for each segment created.

From the drop-down list, select the character that will be used to distinguish  breaks between your account segments. Valid segment separator options  are:

- Dash (**-**)
- Colon (**:**)
- Comma (**,**)
- Period (**.**)



The **Segment Separator** field  can be changed at any time. The default value is the Dash (**-**).

The segment **Position** field automatically  populates in sequential order. There is a separate line for each segment  created. This is a display only field.

Use the segment **Length** field  to assign a character length for each of your segments. The length of  all of your segments combined can be up to 40 characters excluding segment  separators. With segment separators, the total length of all of your segments  can be up to 45 characters.


{:.note}
**The total length of the defined segments is  displayed at the bottom of the screen.**


Once you create an account, only the segment length of the last segment  can be changed. The **Length** field  is disabled for the other segments.

Use the **Short Name** field to  define a unique Short Name for the segment. A **Short 
 Name** is an alphanumeric code that identifies a segment and is limited  by the length assigned to the segment.


{:.example}
If a segment is defined with a length of four  characters, the segment **Short Name**  can be 1-4 characters.


{:.hint}
**To make your segment template more meaningful,  create Short Names with the same number of characters  as the segment length.**


The **Short Name** can be edited  at any time but the number of characters in the Short Name cannot be changed.


{:.example}
A **Short Name**  can be changed from DIV to BRC. It cannot be changed from DIV to BRANCH.

Use the **Description** field to  describe the segment. This is a 40 character alphanumeric field that can  be changed at any time.

This field displays the number of characters in use in your account  segment and cannot be edited.

This non-editable field displays the number of characters remaining  that you can use to add additional segments. If you are anticipating adding  segments to your chart of accounts in the future, make sure that you leave  ample characters unused so that these additional segments can be added.

# Create the Initial Segment Format


After you have determined the required structure for your chart of accounts,  use the **COA Segment Setup** profile  to create the segments. A **Segment**  is a component of the account code that has been defined for reporting  purposes. Each segment is assigned a character length. A **Segment 
 Separator** is used to clearly indicate where one segment ends and  the next segment begins. Segment separators are only used between segments.  There is no segment separator following the last segment.


The segment format may contain a maximum of 40 characters of data, excluding  separators. The segment length including separators may not exceed 45  characters. At least one segment must be defined. The default segment  “ACCOUNT” can be used.


{:.example}
DIV-COMP-ACCT is a segment format that contains  three segments and two segment separators. **Division**  is the first component. It has a length of three characters and is represented  by DIV. **Company** is the second  component. It has a length of four characters and is represented by COMP.  **Account** is the third component.  It has a length of four characters and is represented by ACCT. The Dash  (-) is used to separate segments.


{:.hint}
**It is recommended that you start small when  creating your segment format. Add segments to meet your growing business  needs.**


{:.steps}
To access the COA Segment Setup profile from  the Company Creation Wizard, do the following:

- From the Company Creation Wizard, on the **Segment Format** screen, select **Click Here to Setup Segments Now**. You  will see the **COA Segment Setup**  profile. The first segment defaults to **ACCOUNT**  with a length of seven characters and a description of **Account**.

: [Current Segment Setup](javascript:kadovTextPopup(this)){:id="a1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a1');
//--></script>
: [Number of Segments](javascript:kadovTextPopup(this)){:id="a2"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a2');
//--></script>
: [Segment Separator](javascript:kadovTextPopup(this)){:id="a3"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a3');
//--></script>
: [Position](javascript:kadovTextPopup(this)){:id="a4"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a4');
//--></script>
: [Length](javascript:kadovTextPopup(this)){:id="a5"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a5');
//--></script>
: [Short Name](javascript:kadovTextPopup(this)){:id="a6"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a6');
//--></script>
: [Description](javascript:kadovTextPopup(this)){:id="a7"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a7');
//--></script>
: [Characters Used](javascript:kadovTextPopup(this)){:id="a8"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a8');
//--></script>
: [Characters Remaining](javascript:kadovTextPopup(this)){:id="a9"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a9');
//--></script>


| ![]({{site.sc_baseurl}}/img/lens.gif) | [Menu  Options]({{site.sc_baseurl}}/misc/menu_options_coa_segment_setup_profile.html) |



{:.steps}
To create your initial segment format from  the Company Creation Wizard, do the following:

- : In the **Number of Segments** field, enter the  number of segments to be created. A minimum of one segment must be created.  A line is created at the bottom of the screen for each segment.
- : In the **Segment Separator** field, select the  character to be used to distinguish your segments.
- : In the **Length** field, enter the length of your  segment.
- : In the **Code** field, enter the **Short 
 Name** for your segment. The **Short 
 Name** cannot be greater than the segment length.
- : In the **Description** field, enter a description  of the segment.
- : Enter information  in the **Length**, **Code**,  and **Description** fields for each  segment you create. The **Current Segment 
 Setup** field updates with your segment format.



{:.note}
**Once you create an account, only the segment  length of the last segment can be changed.**

- : View the **Characters Used** and **Characters 
 Remaining** fields. Keep this information in mind, especially if  you would like to have room for adding segments to your structure later.
- : Use the **Move Up** and **Move 
 Down** options to position your segments correctly in the segment  structure.
- : Use the **Delete** option to remove a segment from  your segment format, if necessary.
- : When you are  satisfied with your segment format, click the **Save**  button to save your changes.
- : If you enter  a segment length of more than six characters, you will see a **Confirmation**  dialog box. Click **Yes** to continue  to create the segment or click **No**  to return to the segment and adjust the segment length.
- : If you decided  to keep the default segment, click **Next**  and you will see the **Accounting 
 - Chart of Accounts** screen.
- : If you created  one segment of less than five characters or created multiple segments,  click **Next** and you will see the  **Chart of Accounts - User** **Defined** screen.



| ![]({{site.sc_baseurl}}/img/lens.gif) | [Custom  Chart of Accounts]({{site.sc_baseurl}}/misc/custom_chart_of_accounts.html) |

: ![]({{site.sc_baseurl}}/img/see_also.gif)
: [COA Segment  Setup Profile]({{site.sc_baseurl}}/misc/coa_segment_setup_profile.html)
: [Segmented  Chart of Accounts]({{site.sc_baseurl}}/options/acc-info/coa/chart-of-accounts-details/segmented_chart_of_accounts.html)
: [Add Segments]({{site.sc_baseurl}}/misc/add_segments_segmented_coa.html)
: [Add  Segment to Account Profile]({{site.sc_baseurl}}/misc/add_segment_to_account_profile_segmented_coa.html)
