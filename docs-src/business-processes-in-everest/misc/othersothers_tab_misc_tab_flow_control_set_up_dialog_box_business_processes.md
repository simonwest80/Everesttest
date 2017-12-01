---
title: Other Preferences - Point-of-Sale Documents
---

# Other Preferences - Point of Sale Documents


**Auto-print invoice in Point of Sale document**
: The system prompts you to print the invoice at the  time of saving the document, if this option is selected.


**Allow changing the POS document type to sales  after credit memo is saved**
: Use the **Point of 
 Sale** profile to toggle between a **Point 
 of Sale** (invoice) profile and a **Point 
 of Sale** (sales credit) profile. When you switch to a **Point 
 of Sale** (sales credit) profile to return items to a Point of Sale  customer at a cash register, the document type will continue to be Point  of Sale (sales credit) unless you toggle back to a **Point 
 of Sale** (invoice) profile. If this option is selected, the system  will automatically switch back to a **Point 
 of Sale** (invoice) profile after the **Point 
 of Sale** (sales credit) profile has been created.


**When out of stock non-serialized items are inserted  in a POS document**
: When you include a non-serialized item that is out  of stock on a POS document, **Everest** allows  you to set the default behavior for such items.


| : **Option** | : **Select this option <br/> to:** |
| : None | : Select the items from a separate stock area, or  add quantity. **Everest** asks for  confirmation for the same, if you have selected the location preference  option **Use default stock area to assign <br/> quantity for non-serialized items in sales documents**. If the above  option is unchecked, **Everest** displays  the **Attach Quantity** dialog box. |
| : Adjust Inventory | : Add stock directly using the **Quantity <br/> Adjustment** profile. The **Quantity <br/> Adjustment** profile is displayed if the locational preference **Use default stock area to assign quantity for <br/> non-serialized items in sales documents** is checked. If the above  option is not checked, **Everest**  displays the **Attach Quantity** dialog  box. |
| : Force Sale | : The item type is changed to **Force <br/> Sale** if the locational preference **Use <br/> default stock area to assign quantity for non-serialized items in sales <br/> documents** is checked. If the above option is not checked, **Everest** displays the **Attach <br/> Quantity** dialog box.<br/><br/><br/>![]({{site.bp_baseurl}}/img/lens.gif) [Force  Sale Details]({{site.pos_chm}}/pos-trans/create-pos-doc/pos-si-profile/force-sale/force_sale_pos.html)<br/>: <font color="#000000" class="hcp6">Display the </font>**Force Sale Options** <font color="#000000" class="hcp6">dialog <br/> box if there is partial stock. You can choose to reduce the quantity to <br/> match available quantity, change the unavailable quantity to a force sale <br/> or you can add quantity.</font><br/><br/><br/>![]({{site.bp_baseurl}}/img/lens.gif) [Force  Sale Options Dialog Box](point-of-sale.chm::/force_sale_options_dialog_box.htm) |



**Force sales representative to give reason for  refunds on credit documents at POS**
: A customer may return items on a Point of Sale (credit  memo) document. When you make refunds to customers on these documents,  you may want to track the reasons for such refunds. Use this option to  force the sales representative to enter a reason for the refunds made  to customers when items are returned.
: When you save a Point of Sale (credit memo) document  or select the **Payment** option from  the Point of Sale (credit memo) document, the **Reason 
 for Refund** dialog box will be automatically displayed if you select  this option.


**Prompt to select sales person when creating point  of sale document**
: You may need to keep track of the sales representative  responsible for each sale through your point of sale counter. This option  allows you to automatically display the **Select 
 Sales Person** dialog box when a point of sale document is saved.  If you do not select this option, based on the preferences that have been  set up, the **Sales Representative** field  on the Point of Sale document profile displays the logged in user/the  customer’s sales representative or is left blank.
: ![]({{site.bp_baseurl}}/img/lens.gif) [Sales  person selected automatically at the time of creating a new invoicing  document]({{site.bp_baseurl}}/misc/sales_person_selected_automatically_at_the_time_of_creating_a_new_invoicing_document.html)


{:.see_also}
See also
: [Point  of Sale Tab - Documents Dialog Box]({{site.bp_baseurl}}/flow-ctrl/ctrl/doc-frm/misc/miscellaneous_others_others_3_tab_bp.html)
: [Others  1 Tab - Documents Dialog Box]({{site.bp_baseurl}}/misc/miscellaneous_others_others_1_steps.html)
: [Documents  Dialog Box - Miscellaneous]({{site.bp_baseurl}}/flow-ctrl/ctrl/doc-frm/misc/flow_control_setup_dialog_box_miscellaneous_tab_con.html)
: [Setting  up Flow Control Options]({{site.bp_baseurl}}/flow-ctrl/ctrl/opt/setting_flow_control_options.html)
