---
title: Payments on a Purchase Order
---

# Payments on a Purchase Order


Vendors often require deposits to be made along with purchase orders.  You can make payments against an order by using the **Payment**  > **Pay** option from the **Purchase Order** profile.


{:.note}
You cannot make payments against closed purchase  orders.


**Method for Applying Deposits on a Purchase Invoice**
: You can set a flow control preference to select  the method for applying the deposit on the purchase order while converting  it into a purchase invoice (path: **File**  > **Setup** >**Preferences**  > **Flow Control** > **Documents**  > **Prompts** > **Purchase 
 Document 2** tab).
: You can select one of the following methods:


| **Method** | **Description** |
| Automatically create a new transaction to apply deposit  to Purchase invoice | Select this option to apply the deposit on the purchase  order on the corresponding invoice and show the deposit applied as a new  transaction. |
| Automatically move deposit to Purchase Invoice, if possible.  Otherwise, autos create a new transaction to apply deposit | Select this option to automatically move the deposit  to the purchase invoice. This option will be executed only if the following  conditions are met:<br/><br/><br/>The purchase order and purchase invoice should be created  on the same day.<br/><br/><br/>Only one payment is applicable. If multiple payments  are made on the same purchase order, the system does not move the deposit  to the purchase invoice automatically.<br/><br/><br/>The purchase order and the payment information are shown  as two different transactions if they are created on different days. |
| Prompt user to allow them to select how they would like  to treat the deposit | Select this option to provide user with a prompt for  how to apply the deposit received on a purchase order, on the invoice  while saving the invoice. |
| Keep deposit on the purchase order | Select this option to retain the deposit on the purchase  order so that the user has more control over how to apply the deposit  and the user can manually apply the deposit on the invoice. |

: When you select the **Prompt 
 user to allow them to select how they would like to treat the deposit**  option while applying a deposit to a purchase invoice from a purchase  order, the **Everest Prompt** displays  with further options.
: The **Everest Prompt**  provides you three options:

- Move deposit  from Sales Order to Sales Invoice
- Create a new  transaction to apply deposit to Sales Invoice
- Keep deposit  on this Sales Order

: The deposit applied as per the option selected by  you.


{:.see_also}
See also
: [Flow  Control - Purchase Documents]({{site.bp_chm}}/flow-ctrl/ctrl/doc-frm/prompts/purchase-prompts/flow_control_setup_dialog_box_prompts_purchase_tab_con_businesss_process_in_everest_content.html)
