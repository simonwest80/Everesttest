---
title: Back End Processes - Refund Against a Purchase Invoice
---

# Back End Processes - Refund Against a Purchase Invoice


When a refund is made against a purchase invoice, the following back  end processes occur:

- The vendor's  unposted amount (in the **Vendor**  profile) increases by the amount of refund. The amount payable to the  vendor increases. When the payment journal for the payment is posted,  the unposted amount reduces and the posted amount increases with the amount  refunded. The amount payable to the vendor stays the same.



![]({{site.pp_baseurl}}/img/lens.gif) [Vendor  Profile]({{site.mv_chm}}/creating/the_vendor_profile_steps_by_steps.html)

- The amount  paid on the purchase invoice decreases. If the purchase invoice was initially  fully paid, the purchase invoice status changes to ‘open’.

