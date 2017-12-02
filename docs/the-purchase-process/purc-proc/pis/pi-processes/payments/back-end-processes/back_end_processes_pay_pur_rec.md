---
title: Back End Processes - Payment Against a Purchase Invoice
---

# Back End Processes - Payment Against a Purchase Invoice


When you make a payment against a purchase invoice, the following back  end processes occur:

- The vendor's  unposted amount (in the **Vendor**  profile) reduces by the amount of payment. The amount payable to the vendor  reduces. When the payment journal is posted, the unposted amount increases  and the posted amount reduces by the amount paid. The amount payable to  the vendor stays the same.
- The amount  paid on the purchase invoice increases. If the total amount paid on purchase  invoice equals the value of the purchase invoice, then the purchase invoice  status changes to ‘paid’.
- If the amount  is paid by applying a debit memo, the vendor's balances are not affected  but the amount payable by the vendor on the debit memo reduces by the  amount applied.
- If the amount  is paid by applying an existing deposit on order, the vendor's balances  are not affected but the deposits available on the purchase order reduce  by the amount applied.

