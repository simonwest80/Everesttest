---
title: The Forms Browser
---
<script type="text/javascript" language="JavaScript1.2" x-save-method="compute-relative" src="{{site.fd_baseurl}}/misc/ehlpdhtm.js"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
This describes the class of the custom form version. (Example: Sales  Quote, Sales Order, Sales Invoice, Credit Quote, Credit Order, and Credit  Memo)

This shows the name of the form versions available.

This shows the name of the document class. (Example: Sales Documents  and Purchase Documents)

The **System** form is the base  form of all versions of each class and this cannot be edited or deleted.  The edited system form versions can be saved in different name which enables  the user to create the new form versions.


{:.note}
: No form version can be set as a **System**  form. The **System** form can be assigned  to different users and groups and can be set as a **Default**  form.   The  **System** form is set as the default  form in the absence of a version being set as default.

The **Default** form  is the form version displayed when you access a profile or document absent  any overriding form assignments.  In  other words, the **Default** form  is globally assigned to all users.  This  global assignment is overridden by a group or user assignment.


{:.note}
: Only one version can be the **Default**  form for any form class. You can view the **Default**  form for each form class in the **Forms**  browser.  If  no **Default** form is set, then the  **System** form is set as the **Default** form.


The form version a user sees when opening a profile is determined  by the following Cascading Form assignments:

- User’s version  assigned to you
- User group’s version  assigned to your group



{:.note}
: If you are not assigned any form version and have  multiple group assignments with different versions, then the system will  choose the alphabetically first version.

- Default form assigned
- System form assigned



{:.note}
: Authorized user with security rights can set a form  version as a **Default** form. To  set a form version as the **Default**  form, right click on the form version and choose **Set 
 as default**.

This describes the type of the custom form versions (Example: Profile,  Document etc.) available in the Forms browser.

# The Forms Browser


The **Forms** browser provides a  central location to manage the customization of forms. Forms are created  using the Forms Designer and managed using the **Forms**  browser. The standard versions of each customizable profile are displayed  in this list along with any form versions that were created using the  Forms Designer. The **Forms** browser  is only enabled for users with the appropriate security rights.


In the **Forms** Browser, you will  see the following five columns:

- [Form  Class](javascript:kadovTextPopup(this)){:id="a1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a1');
//--></script>
- [Form  Name](javascript:kadovTextPopup(this)){:id="a2"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a2');
//--></script>
- [Document  Class](javascript:kadovTextPopup(this)){:id="a6"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a6');
//--></script>
- [System  ](javascript:kadovTextPopup(this)){:id="a3"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a3');
//--></script>
- [Default](javascript:kadovTextPopup(this)){:id="a4"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a4');
//--></script>
- [Type](javascript:kadovTextPopup(this)){:id="a5"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a5');
//--></script>



![]({{site.fd_baseurl}}/img/see_also.gif)
: [Access the  Forms Browser]({{site.fd_baseurl}}/misc/access_the_forms_browser.html)
: [Access  to Profile Version User/Group Assignment]({{site.fd_baseurl}}/misc/access_to_profile_version_user_group_assignment.html)
: [Working  with the Forms Designer]({{site.fd_baseurl}}/forms-designer/working_with_the_forms_designer.html)
