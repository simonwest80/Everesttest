---
title: General Details
---

# General Details


In the **General** tab of the **Custom Tracking Group** profile for documents,  you are required to specify details of the tracking group being generated.


**Group Code**
: Group code is the unique number assigned to the  custom tracking group. It is automatically generated when you save a new  custom tracking group.


**Description**
: The description identifies the tracking group. The  description must specify the information that is to be obtained.
: ![example.gif]({{site.ct_baseurl}}/img/example.gif)  ‘Shipment  Status’ or  ‘Approval Status’.


**Allow multiple selections to be tagged**
: If a group allows multiple selections to be tagged,  a record can be tagged with more than one selection for the group. **Everest** warns you with a message **Disabling the multiple tag option will not 
 affect pre-existing selections. Are you sure you want to change the setting?**  if you have pre-existing selections and want to uncheck the above option.  Click **Yes** if you do not want to  allow multiple selections to be tagged to documents.
: ![example.gif]({{site.ct_baseurl}}/img/example.gif)  If  multiple selection is allowed for the tracking group (for purchase quotes)  ‘Approval Status’  with tracking choices of ‘Approved by Purchase Manager’  and ‘Approved by Purchase Executive’,  then a document can be tagged with more than one choice for the group.  This signifies that the document tagged with both ‘Approved by Purchase  Manager’ and  ‘Approved by Purchase Executive’  has been approved by both.
: ![]({{site.ct_baseurl}}/img/note.gif) If you have tagged a particular  document with multiple choices for the group, and after tagging, you try  to clear the option **Allow Multiple Selection 
 to be Tagged**, **Everest** prompts  you that clearing the multiple selection option will not affect existing  selections tagged to documents and asks if you want to disable the setting.


**Transfer tags across documents**
: If you select this check box, the tags defined  for a document get transferred to the next document on conversion.


**Refresh tag date if memo is updated**
: When an item is tagged with a choice, **Everest**  records the date of tagging. This option ensures that whenever you modify  the notes to the choice, the tag date gets updated, and is useful to record  the date and time when the memo was last updated.
: ![example.gif]({{site.ct_baseurl}}/img/example.gif)  If  a quote is tagged with the selection ‘Rejected’ for the group ‘Approval  Status’, you  can append the reasons for rejection as a note.


**Web-enabled**
: The tracking groups that are created can also be  enabled to appear in different sections of your **Everest 
 E-Commerce** store. You can Web enable relevant document tracking  groups to display the following information on your **Everest 
 E-Commerce** store.

- **Displaying 
 shipment tracking numbers against a sales order** -The customer can  click the tracking number (which is linked to the carrier's Web page using  the delivery method) to see the current location of the shipment.
- **Displaying 
 status of sales orders** - For example, you could create a tracking  group for ‘Order Status’  with choices of ‘Payment Received’,  ‘Payment Approved’  and ‘Payment Pending’.
- **Displaying 
 status of sales returns** - For example, you could create a tracking  group for ‘Returns Status’  with choices of ‘Returns Received’,  ‘Returns Approved’,  and ‘Customer Account Credited’.



![Lens.gif]({{site.ct_baseurl}}/img/lens.gif) [Delivery  Methods]({{site.sc_chm}}/options/everest-freight-estimator/delivery-methods/delivery_methods_sales4.html)


Security


**Security Description**
: This field defines the security right for access  to the custom tracking group created.
: Only those users who are assigned with this security  right can tag any selection belonging to this group.
: ![Lens.gif]({{site.ct_baseurl}}/img/lens.gif) [Userdefined  Security Rights]({{site.sc_chm}}/options/security/security-rights/userdefined_security_rights.html)


{:.see_also}
See also
: [Custom  Tracking Group Details]({{site.ct_baseurl}}/document-tracking/tracking-purchase-documents/custom_tracking_group_details_for_purchase_documents.html)
