---
title: Address and Security Code Verification Details
---

# Address and Security Code Verification Details


Although **Everest** supports verification  of the customer’s address and card verification value, in a Point of Sale  scenario, this is normally not carried out.

- Verification  of the address is applicable only if you select a normal customer code  where the customer’s address is defined. If the customer is a default  Point of Sale customer (POS\_CUST),  the customer’s address is normally not verified.
- Verification  of the card verification value is useful only when the cardholder is not  present. In Point of Sale transactions, the cardholder is physically present.  Therefore, it is not necessary to check for the card verification value.



It is recommended that for credit card payment methods used in Point  of Sale transactions, you clear the **Address 
 Verification** **(AVS)**  and the **Security Code Verification****(CVV2)** check boxes in the [**Payment Method** profile]({{site.sc_chm}}/options/payment-information/payment-methods/set-up-a-payment-method/the_payment_method_profile.html) (path: **File** > **Setup**  > **Accounting** > **Payment****Methods** > **Options 
 &gt; Edit &gt; In New Window &gt; Credit** **Card****Processing** tab).


{:.see_also}
See also
: [Set  Up a New Processor]({{site.sc_chm}}/options/payment-information/credit-card-processing/create-a-processor/set_up_a_new_processor.html)
: [Card  Verification Details]({{site.pos_baseurl}}/pos-trans/create-pos-doc/pos-receipts/proc-cc-pmnts/receiving/verify-dtls/card_verification_details_pos.html)
