namespace HiBaPaximum.Enumarations;

public enum OfferAvailability
{
    Available=1,	
    //This offer can be used in bookings but not confirmed right away. Operator should be in contact with the supplier, confirmation process can take up to 24 hours.
    Request=2,		
    //The offer is not available right now and cannot be used for booking.
    NotAvailable=3		
}