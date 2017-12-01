---
title: Method for applying deposit collected on a sales order when converting it to a sales invoice
---

# Method for applying deposit collected on a sales order when converting  it to a sales invoice


**Everest** calculates finance charges  on overdue sales documents based on the amounts outstanding in the document.  **Everest** provides you with the  following options to apply deposits:


| Field Name | **Description** |
| Automatically create a new transaction to apply deposit to Sales Invoice | Select this option to automatically apply the deposit from the sales  order to the sales invoice on saving the invoice. The paid field is automatically  populated with the applied deposit from the sales order. The net amount  due from the customer is the invoice amount less the deposit. The amount  applied is shown as a separate new transaction on the sales invoice. |
| Automatically move deposit to Sales Invoice, if possible. Otherwise,  auto create transaction to apply deposit. | Select this option to automatically move the deposit to the sales invoice.  This option will be exceuted only if the following conditions are met:<br/><br/>- The sales order  and sales invoice are created on the same day.<br/>- There is only one  payment on the sales order. If multiple payments are made on the same  sales order, the system does not move the deposit to the sales invoice  automatically.<br/><br/><br/><br/>The sales order and the payment information are shown as two different  transactions if they are created on different days. |
| Prompt user to allow them to select how they would like to treat the  deposit | Select this option to prompt users with options for applying the deposit  when they save the sales invoice after converting a sales order to a sales  invoice. The Everest Prompt displays while applying the deposit from a  sales order to a sales invoice. |
| Keep deposit on the Sales Order | This option does not move the deposit and retains the deposit on the  sales order. This gives the user more control on when and how to apply  the deposit received on a sales order. The entire invoice amount becomes  the amount due from the customer on the document since the amount received  on the order is not applied. The deposit made against the order can be  applied to any other sales document of the customer or applied on the  invoice on a different date. |



When you select the option **Prompt 
 user to allow them to select how they would like to treat the deposit**  while converting a sales order to a sales invoice, the Everest Prompt  displays.


The **Everest Prompt**  provides you three options:

- Move deposit from  Sales Order to Sales Invoice
- Create a new transaction  to apply deposit to Sales Invoice
- Keep deposit on  this Sales Order



{:.see_also}
See also
: [Prompts  - Sales Document - Sales Document 2]({{site.bp_baseurl}}/flow-ctrl/ctrl/doc-frm/prompts/sales-prompts/prompts_sales_document_sales_document_2.html)
: [Setting  up Flow Control Options]({{site.bp_baseurl}}/flow-ctrl/ctrl/opt/setting_flow_control_options.html)
