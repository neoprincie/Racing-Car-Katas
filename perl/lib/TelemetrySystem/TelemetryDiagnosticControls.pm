package TelemetryDiagnosticControls;

use strict;
use warnings;

use lib 'lib/TelemetrySystem';

require TelemetryClient;

sub new {
    my ( $class ) = @_;
    my $self = {
        diagnosticChannelConnectionString => "*111#",
        telemetryClient => new TelemetryClient(),
        diagnosticInfo => ""
    };

    bless $self, $class;

    return $self;
}

sub checkTransmission {
    my ( $self ) = @_;

    $self->{diagnosticInfo} = "";

    $self->{telemetryClient}->disconnect();

    my $retryLeft = 3;
    while(! $self->{telemetryClient}->{onlineStatus} && $retryLeft > 0 ) {
        $self->{telemetryClient}->connect($self->{diagnosticChannelConnectionString});
        $retryLeft = $retryLeft - 1;
    }

    if( ! $self->{telemetryClient}->{onlineStatus} ) {
        die "unable to connect";
    }

    $self->{telemetryClient}->send($self->{telemetryClient}->{diagnosticMessage});
    $self->{diagnosticInfo} = $self->{telemetryClient}->receive();
}

1;