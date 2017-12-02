---
title: Automatically transfer pending authorizations from Sales Order to Sales Invoice
---

# Automatically transfer pending authorizations from Sales Order to Sales  Invoice


Select whether or not pending credit card authorizations available in  the sales order should be automatically transferred when a sales order  is converted to a sales invoice. Enabling this option allows you to more  easily process payments from the batch payment browsers after an order  has been shipped.


{:.note}
When an order is partially invoiced and this  option is enabled, the system will transfer the pending authorization  to the partial invoice and retain a copy for the remainder of the order.  This copied batch payment will use the same credit card information but  will change to a “Sale” type transaction during future processing. The  type change happens because the authorization will be consumed by the  partial invoice.


{:.see_also}
See also
: [Prompts  - Sales Document - Sales Document 2]({{site.bp_baseurl}}/flow-ctrl/ctrl/doc-frm/prompts/sales-prompts/prompts_sales_document_sales_document_2.html)
