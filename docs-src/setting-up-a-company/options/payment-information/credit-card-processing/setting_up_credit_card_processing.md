---
title: Setting up Credit Card Processing
---

# Setting up Credit Card Processing


Setting up credit card processing comprises the following:

1. Opening a merchant  account with a financial institution that provides merchant accounts for  credit card payments.
- [Setting  up an account]({{site.sc_baseurl}}/options/acc-info/coa/setup-coa/creating_an_account.html) in your Chart of Accounts for this new account.
- Subscribing  to a payment service or a payment software to get a merchant account.  **Everest** supports the Payflow Pro  payment service and the ICVerify software. In the case of ICVerify, you  have to buy their software and install it. It also supports other services  like WorldPay.
- [Setting  up processors]({{site.sc_baseurl}}/options/payment-information/credit-card-processing/create-a-processor/creating_a_new_processor.html). Set up a processor for each merchant account that you  will use to process credit cards.
- [Setting  up payment methods]({{site.sc_baseurl}}/options/payment-information/payment-methods/set-up-a-payment-method/creating_a_new_payment_method.html) for credit cards and attaching the required processor.  Ensure that the account you set up in the first step is selected in the  **Account** field of the **Payment****Method** profile. This enables reconciling  this account with the statement from your service provider.



{:.note}
If you purchase a payment software or subscribe to payment services  other than those supported by **Everest**:

- Create payment  methods but do not assign processors in the **Payment****Method** profile.
- When credit  card payments are received, enter the details of the payment for the document  in **Everest**. Process the payments  outside **Everest**.


{:.see_also}
See also
: [Credit  Card Processing with ICVerify]({{site.sc_baseurl}}/options/payment-information/credit-card-processing/credit_card_processing_with_ic_verify.html)
: [Credit  Card Processing with Payflow Pro]({{site.sc_baseurl}}/options/payment-information/credit-card-processing/credit_card_processing_with_payflow_pro_setup.html)
: [Creating  a new processor]({{site.sc_baseurl}}/options/payment-information/credit-card-processing/create-a-processor/creating_a_new_processor.html)
