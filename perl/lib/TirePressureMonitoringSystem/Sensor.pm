package Sensor;

use strict;
use warnings;

use parent 'ISensor'

sub new {
    my ( $class ) = @_;
    my $self = {
        offset => 16
    };

    bless $self, $class;

    return $self;
}

sub popNextPressurePsiValue {
    my ( $self ) = @_;

    my $pressureTelemetryValue = samplePressure();
    return $self->{offset} + $pressureTelemetryValue;
}

sub samplePressure {
    my ( $self ) = @_;

    my $pressureTelemetryValue = 6 * rand() * rand();
    return $pressureTelemetryValue;
}

1;