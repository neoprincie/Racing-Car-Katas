package TurnTicket;

use strict;
use warnings;

sub new {
    my ( $class, $turnNum ) = @_;
    my $self = {
        turnNumber => $turnNum
    };

    bless $self, $class;

    return $self;
}

1;