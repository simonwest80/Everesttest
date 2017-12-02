---
title: Prompts - Purchase Document - Purchase Document 1
---

# Prompts - Purchase Document - Purchase Document 1


Use the **Purchase Document 
 1** tab to set up prompts for item cost related functions for purchase  documents.


**When copying items from a sales document to a  purchase document (including automated purchases), which cost do you wish  to use for the new purchase document?**
: Select the type of cost to be used for the item  in the purchase order when copying items from a sales order into a purchase  order (for drop shipments).


**![]({{site.bp_baseurl}}/img/lens.gif) [When  copying items from a sales document to a purchase document (including  automated purchases), which cost do you wish to use for the new purchase  document?]({{site.bp_baseurl}}/misc/copy_items_from_a_sales_order_to_a_purchase_order_dropshipping_cost_to_use_for_the_purchase_order.html)**


**When the last cost of an item changes at the  time of receiving, how do you wish to prompt the user for updating the  last cost?**
: Select a method to decide how the last cost for  an item has to be updated whenever a purchase invoice is created.


**![]({{site.bp_baseurl}}/img/lens.gif) [When  the last cost of an item changes at the time of receiving, how do you  wish to prompt the user for updating the last cost?]({{site.bp_baseurl}}/misc/when_the_last_cost_of_an_item_changes_at_the_time_of_creating_a_purchase_receipt_how_do_you_wish_to_.html)**


**Enter Percent**
: Enter a default percentage by which if the current  last cost varies from the previous last cost, the user is prompted whether  to update the **Item** profile (path:  **Inventory** > **Items**  > **Options** > **Edit**  > **In New Window**) with the current  last cost.


![]({{site.bp_baseurl}}/img/lens.gif) [Enter  Percent]({{site.bp_baseurl}}/misc/enter_percent.html)


**Select the default date option based on which  the records will be displayed in the purchase browser**
: Specify the filter that should automatically be  applied to purchase document browsers.
: ![]({{site.bp_baseurl}}/img/lens.gif) [Select  the default date option based on which the records will be displayed in  the purchase browser]({{site.bp_baseurl}}/misc/select_the_default_date_option_based_on_which_the_records_will_be_displayed_in_the_purchase_browser.html)


**When adding an item to a purchase document, which  cost would you like to use?**
: Select the cost that should be used when you retrieve  an item to a purchase document.
: ![]({{site.bp_baseurl}}/img/lens.gif)[When  adding an item to a purchase document, which cost would you like to use?]({{site.bp_baseurl}}/misc/when_adding_an_item_to_a_purchase_document,_which_cost_would_you_like_to_use_bp.html)


**When adding an item to a debit document, which  cost would you like to use?**
: Select the cost to use when you retrieve an item  into a debit document. For a new company, this field defaults to the Item  Last Cost option. When a company is upgraded, it defaults to the preference  set in the **Default value for the user 
 defined cost column in a document** field (path: **File**  > **Setup** > **Preferences**  > **Flow Control** > **Other 
 Flow Control** > **Item Cost**  / **Sales Summary** tab).
: ![]({{site.bp_baseurl}}/img/lens.gif)[When  adding an item to a debit document, which cost would you like to use?]({{site.bp_baseurl}}/misc/when_adding_an_item_to_a_debit_document_which_cost_bp.html)


**Default quantity when an item is added to a purchase  order/receipt**
: Define the quantity automatically assigned for a  newly added item to the ordered column of a purchase order or the received  column of a purchase receipt created directly.

- **EOQ**  – the minimum quantity of each item that you want to purchase from a vendor  as defined in the Item Profile Replenishment tab.
- **Single 
 unit of Purchase Measure** – one unit of the purchase measure as  defined in the Item Profile Purchases tab.

: **Prompt if the ordered/received 
 quantity is less than EOQ** - check this box to have the system prompt  you on saving the document if the input quantity ordered in a purchase  order or received in a purchase receipt differs from the EOQ. When prompted,  you may save the document with the different quantity or postpone the  save so you can edit the ordered/received quantity.
: On migration from Everest 3.0 to Everest 4.0, the  system defaults to Single Unit of Purchase Measure for the default quantity  with the prompt checkbox checked. When setting up a new company, the system  defaults to EOQ with the prompt checkbox unchecked.


{:.see_also}
See also
: [Documents  Dialog Box - Prompts]({{site.bp_baseurl}}/flow-ctrl/ctrl/opt/prompts-tab/flow_control_setup_dialog_box_prompts_tab_steps.html)
