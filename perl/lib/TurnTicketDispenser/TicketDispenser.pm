package TicketDispenser;

use strict;
use warnings;

use lib 'lib/TurnTicketDispenser';

require TurnTicket;
require TurnNumberSequence;

sub new {
    my ( $class ) = @_;
    my $self = {
    };

    bless $self, $class;

    return $self;
}

sub getTurnTicket {
    my ( $self ) = @_;

    my $newTurnNumber = TurnNumberSequence->getNextTurnNumber();
    my $newTurnTicket = new TurnTicket($newTurnNumber);

    return $newTurnTicket;
}

1;