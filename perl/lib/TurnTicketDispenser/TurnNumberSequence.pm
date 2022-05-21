package TurnNumberSequence;

use strict;
use warnings;

my $turnNumber = 0;

sub getNextTurnNumber {
    my $nextTurnNumber = $turnNumber;
    $turnNumber = $turnNumber + 1;

    return $nextTurnNumber;
}

1;