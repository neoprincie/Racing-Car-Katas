package TelemetryClient;

use strict;
use warnings;

sub new {
    my ( $class ) = @_;
    my $self = {
        diagnosticMessage => "AT#UD",
        onlineStatus => '0',
        diagnosticMessageResult => ""
    };

    bless $self, $class;

    return $self;
}

sub connect {
    my ( $self, $telemetryServerConnectionString ) = @_;

    if ( ! defined $telemetryServerConnectionString || $telemetryServerConnectionString eq "") {
        die "argument is undefined or empty";
    }

    my $success = (1 + int rand(10)) <= 8;

    $self->{onlineStatus} = $success;
}

sub disconnect {
    my ( $self ) = @_;

    $self->{onlineStatus} = '0';
}

sub send {
    my ( $self, $message ) = @_;

    if ( ! defined $message || $message eq "") {
        die "argument is undefined or empty";
    }

    if ( $message eq $self->{diagnosticMessage} ) {
        $self->{diagnosticMessageResult} = 
            "LAST TX rate................ 100 MBPS\r\n"
          . "HIGHEST TX rate............. 100 MBPS\r\n"
          . "LAST RX rate................ 100 MBPS\r\n"
          . "HIGHEST RX rate............. 100 MBPS\r\n"
          . "BIT RATE.................... 100000000\r\n"
          . "WORD LEN.................... 16\r\n"
          . "WORD/FRAME.................. 511\r\n"
          . "BITS/FRAME.................. 8192\r\n"
          . "MODULATION TYPE............. PCM/FM\r\n"
          . "TX Digital Los.............. 0.75\r\n"
          . "RX Digital Los.............. 0.10\r\n"
          . "BEP Test.................... -5\r\n"
          . "Local Rtrn Count............ 00\r\n"
          . "Remote Rtrn Count........... 00";

          return;
    }

    # here should go the real Send operation
}

sub receive {
    my ( $self ) = @_;

    my $message = "";

    if ( $self->{diagnosticMessageResult} ne "") {
        $message = $self->{diagnosticMessageResult};
        $self->{diagnosticMessageResult} = "";
    }
    else {
        $message = "";
        my $messageLength = 50 + int rand(60);

        for(my $i = $messageLength; $i >= 0; --$i) {
            $message = $message + (40 + int rand(86));
        }
    }

    return $message;
}

1;