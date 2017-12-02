---
title: Method for applying deposit paid on a purchase order when converting it to a purchase invoice
---

# Method for applying deposit paid on a purchase order when converting  it to a purchase invoice


**Everest** provides you with the  following options to decide how you want to treat the deposits made on  a purchase order:


{:.example}
A particular vendor delivers items only when  payment is made. The company wants quick delivery of the items and decides  to prepay for the merchandise The Accounting Department is able to track  and move the deposit to the purchase invoice at the time of creation using  these preferences.


| Field | Description |
| Automatically create a new transaction to apply deposit  to Purchase invoice | Select this option to automatically create a new transaction  while applying the deposit received on a purchase order to the purchase  invoice at the time of saving the invoice. The amount received on the  purchase order is applied to the purchase invoice and reflected in the  Paid field. The net amount due to the vendor is the invoice amount less  the deposit. |
| Automatically move deposit to Purchase Invoice, if possible. Otherwise,  auto create a new transaction to apply deposit | Select this option to automatically move the deposit to the purchase  invoice. This option will be executed only if the following conditions  are met:<br/><br/>- The purchase order  and purchase invoice are created on the same day.<br/>- There is only one  payment on the purchase order. If multiple payments are made on the same  purchase order, the system does not move the deposit to the purchase invoice  automatically.<br/><br/><br/><br/>The payment information is shown as a new transaction  if the purchase order and invoice are created on different days. |
| Prompt user to allow them to select how they would like to treat the  deposit | Select this option for a prompt to decide how you would like to move  the deposit received on the purchase order to the corresponding purchase  invoice. When you save the purchase invoice, the system provides you with  the following prompt to check how you would like to apply the deposit. |
| Keep deposit on the Purchase Order | This option does not move the deposit and retains the deposit on the  purchase order. This gives the user more control on when and how to apply  the deposit received on a purchase order. The entire invoice amount becomes  the amount due to the vendor on the document since the amount received  on the order is not applied. The deposit made against the order can be  applied to any other purchase document of the vendor or applied on the  invoice on a different date. |



When you select the option **Prompt 
 user to allow them to select how they would like to treat the deposit**  while converting a purchase order to a purchase invoice, the **Everest 
 Prompt** displays.


The **Everest Prompt**  provides you three options:

- Move deposit from  Purchase Order to Purchase Invoice
- Create a new transaction  to apply deposit to Purchase Invoice
- Keep deposit on  this Purchase Order



{:.see_also}
See also
: [Prompts  - Purchase Document - Purchase Document 2]({{site.bp_baseurl}}/flow-ctrl/ctrl/doc-frm/prompts/purchase-prompts/prompts_purchase_document_purchase_document_2_bp.html)
: [Setting  up Flow Control Options]({{site.bp_baseurl}}/flow-ctrl/ctrl/opt/setting_flow_control_options.html)
