use strict;
use warnings;

use Test::More 0.96;

use lib 'lib/TurnTicketDispenser';

require TicketDispenser;

subtest 'foo' => sub {
    my $ticketDispenser = new TicketDispenser();
    my $turnTicket = $ticketDispenser->getTurnTicket();
};

done_testing();