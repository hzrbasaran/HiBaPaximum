namespace HiBaPaximum.Enumarations;

public enum BookingTransactionStatus
{
    Errored=0,	
    Completed=1,	
    ThirdPartyCompleted=2,	
    Committing=3,	
    Open=4,	
    Expired=5,	
    Cancelled=6,	
    Reserved=7,	
    RollbackFailed=8,	
    PartialCancel=9,	
    CancelX=10,	
    Modified=11	
}