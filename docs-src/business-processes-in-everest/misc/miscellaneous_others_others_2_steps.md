---
title: Miscellaneous - Others - Others 2
---
<script type="text/javascript" language="JavaScript1.2" x-save-method="compute-relative" src="{{site.bp_baseurl}}/misc/ehlpdhtm.js"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
| **Accounts** | Posting Group | Posting Group |
| Sales | Customer Posting Group | Inventory Posting Group |
| Sales Return | Customer Posting Group | Inventory Posting Group |
| Sales Line Item Discounts | Customer Posting Group | Inventory Posting Group |
| Gain on Purchase Returns | Vendor Posting Group | Inventory Posting Group |
| Loss on Purchase Returns | Vendor Posting Group | Inventory Posting Group |

# Miscellaneous - Others - Others 2


Location/Sub-Location


**Allow user to open only those invoicing documents  that belong to his/her default location/sub-location**
: Select this check box if you want users to view  only those sales documents that belong to the user’s location/sub-location.
: ![]({{site.bp_baseurl}}/img/lens.gif) [Location/Sub-Location  Details]({{site.bp_baseurl}}/misc/department_others_tab_misc_tab_flow_control_set_up_dialog_box_business_processes.html)


**Allow user to open only those purchasing documents  that belong to his/her default location/sub-location**
: Select this check box if you want users to view  only those purchase documents that belong to the user’s location/sub-location.
: ![]({{site.bp_baseurl}}/img/lens.gif) [Location/Sub-Location  Details]({{site.bp_baseurl}}/misc/department_others_tab_misc_tab_flow_control_set_up_dialog_box_business_processes.html)


**Restrict sales reps from viewing all customers**
: Select this check box to prevent sales representatives  from viewing the records of customers who are not assigned to them.
: ![]({{site.bp_baseurl}}/img/lens.gif)[Restriction  on Sales Representatives]({{site.bp_baseurl}}/misc/restriction_on_sales_representatives_flow_cntrl_misc_others_2_tab.html)


**Restrict sales reps from viewing sales documents**
: Select this check box to prevent sales representatives  from viewing the sales documents that are not assigned to them.
: ![]({{site.bp_baseurl}}/img/lens.gif)[Restriction  on Sales Representatives]({{site.bp_baseurl}}/misc/restriction_on_sales_representatives_flow_cntrl_misc_others_2_tab.html)


**Default address for AVS**
: Specify the default address to be used for address  verification.
: ![]({{site.bp_baseurl}}/img/lens.gif) [Default  Address for AVS]({{site.bp_baseurl}}/misc/default_address_for_avs.html)


**Link the serial number/lot number of input items  to the assembly item**
: Select whether or not the serial/lot numbers of  the input items in an assembly have to be linked with the output/assembled  item.
: ![]({{site.bp_baseurl}}/img/lens.gif) [Link  the serial number/lot number of input items to the assembly item]({{site.bp_baseurl}}/misc/link_the_serial_number_lot_number_of_input_items_to_the_assembly_itemcontents_documents_db.html)


**Exchange rate used when converting quotes and  orders**
: Specify the default exchange rate to be used when  you process intermediate documents.
: This preference does not apply when you convert  multiple purchase orders into a single purchase receipt or purchase invoice.  In these cases the purchase receipt/invoice uses the latest exchange rate.
: ![]({{site.bp_baseurl}}/img/lens.gif) [Exchange  rate used when converting quotes and orders]({{site.bp_baseurl}}/misc/exchange_rate_used_when_converting_quotes_and_orders.html)


**Prompt when trying to retrieve and serialize  an item that is not already present on a document**
: Select this check box to be prompted when trying  to retrieve and serialize an item that is not already present on a document.
: ![]({{site.bp_baseurl}}/img/lens.gif)  [Additional  Information]({{site.bp_baseurl}}/misc/prompt_when_trying_to_retrieve_and_serialize_an_item_not_already_present_on_the_document.html)


**[]()Posting  Group used to resolve GL accounts**
: This section indicates the Posting Group that is  to be used in a sales or purchase document. The following options are  available:

- Inventory Posting  Groups
- Customers and  Vendors Posting Groups

: It is possible for certain accounts to be common  among Posting Groups types. To avoid any conflict resulting from this  during the creation of a transaction, it is essential to set this preference.  The [table](javascript:kadovTextPopup(this)){:id="a1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a1');
//--></script>  shows the Posting Groups that are common for a particular account.
: The customer grid (in a sales transaction)and the  vendor grid (in a purchase transaction) will always display the accounts  resolved from their respective Posting Groups.
: The  Posting Group that is used is based on the hierarchy (give link for hierarchy).
: However the line items will display the data for  the common accounts based on the preference setting.


**If the preference setting is Inventory Posting  Groups:**

- Sales
- Sales Returns
- Sales Line  Item Discounts
- Gain on Purchase  Returns
- Loss on Purchase  Returns

: For each line item, all the above accounts will  be based on the Inventory Posting Group associated to the line item.
: For the customer gird (sales transactions), the  sales, Sales returns and Sales Line item discounts will be still be based  on the Customer Posting Group, however they will have a gray background  with a legend indicating that in the transaction, the inventory Posting  Group’s account will be used.
: For the vendor grid (purchase transactions), the  Gain on Purchase Returns and Loss on Purchase Returns will still be based  on the vendor  Posting  Group, however they will have a gray background with a legend indicating  that in the transaction, the inventory Posting Group’s account will be  used.
: **&nbsp;Illustration:**


|  | Sales | Sales Returns | Sales Line Item Discounts |
| Customer Posting Group | R50 | R150 | R250 |
| Line Item A | R600 | R200 | R800 |
| Line Item B | R100 | R200 | R300 |

: In the above example, the customer grid will display  the accounts resolved from the customer posting group itself, but with  a gray background since the preference is set to Inventory Posting Group.
: However the Sales, Sales Returns and Sales Line  Item Discounts for each line item will display their respective accounts.
: And in the transaction, both the Revenue accounts  and both the sales line item discount accounts will be used.


**If the preference setting is Customer and Vendor  Posting Groups:**
: The customer/vendor  grid  will display the accounts based on the respective customer /vendor posting  group.
: All the line items will also display the conflicting  accounts based only on the customer/vendor Posting Group .
: **&nbsp;Illustration:**


|  | Sales | Sales Returns | Sales Line Item Discounts |
| Customer Posting Group | R50 | R150 | R250 |
| Line Item A | R600 | R200 | R800 |
| Line Item B | R100 | R200 | R300 |



In the  Posting Accounts Information screen the Sales, Sales Returns and Sales  Line Item Discounts for each line item will also display R 50,R150  and  R250. They will with a gray background since the preference is set to  Customer Posting Group.


And in the transaction, the customer/vendor accounts will be used, not  the inventory accounts.


{:.note}
: The Posting Group that is used to resolve the default  accounts in this screen is based on hierarchy.
: Also, not all the accounts get resolved from the  same Posting Group. So the Sales account can get resolved from the Posting  Group 1 which is associated to the customer, but if the Sales Return account  is not defined  in  Posting Group 1,  then  it will look at the Posting Group associated with customer class to resolve  the Sales Return account.
: User  may edit any of the accounts in the Posting Account information screen,  but cannot leave any cell blank (except for Asset/liability/Expense account  for non-inventoried items).


| ![]({{site.bp_baseurl}}/img/lens.gif) | **[Hierarchical  order for Customer Posting Group]({{site.bp_baseurl}}/misc/hierarchical_order_for_customer_posting_group_doc_flow_control_misc_other2_tab.html)** |



| ![]({{site.bp_baseurl}}/img/lens.gif) | **[Hierarchical  order for Inventory Posting Group]({{site.bp_baseurl}}/misc/hierarchical_order_for_inventory_posting_group_doc_flow_control_misc_other2_tab.html)** |



{:.see_also}
See also
: [Documents  Dialog Box - Miscellaneous - Others Tab]({{site.bp_baseurl}}/flow-ctrl/ctrl/opt/misc/miscellaneous_others_step_by_step_business_process_in_everest.html)
: [Other  Posting Accounts Browser Information]({{site.sp_chm}}/misc/other_information_posting_acc_doc_info_common_sales_doc_options.html)
