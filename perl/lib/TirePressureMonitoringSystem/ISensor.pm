package ISensor;

use strict;
use warnings;

sub new {
    my ( $class ) = @_;
    my $self = {};

    bless $self, $class;

    return $self;
}

sub popNextPressurePsiValue {
    return -1;
}

1;