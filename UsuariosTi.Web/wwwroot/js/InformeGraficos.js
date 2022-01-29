
//FALTOU : _BlockDisponibilidadeRedeFocoNegocialZero,  
function GraficoEvolucaoMensal() {
  var ProgressoEvolucaoMensal = $('#divGraficoEvolucaoMensal').data('grafico');

  Highcharts.chart('divGraficoEvolucaoMensal', {
    chart: {
      type: 'column'
    },
    title: {
      text: ''
    },
    subtitle: {
      text: ''
    },
    xAxis: {
      categories: ProgressoEvolucaoMensal.categories,
    },
    yAxis: {
      min: 0,
      title: {
        text: ''
      }
    },
    credits: {
      enabled: false
    },
    tooltip: {
      headerFormat: '<span style="font-size:10px">{point.key}</span><table>',
      pointFormat: '<tr><td style="color:{series.color};padding:0;font-weight:bolder;">{series.name}: </td>' +
          '<td style="padding:0"><b>{point.y:.2f} %</b></td></tr>',
      footerFormat: '</table>',
      shared: true,
      useHTML: true
    },
    exporting: {
      enabled: false,
    },
    plotOptions: {

      column: {
        pointPadding: 0.2,
        borderWidth: 0,
        dataLabels: {
          enabled: true
        }
      }
    },
    series: ProgressoEvolucaoMensal.series,
  });
}

function GraficoCapacitacao() {
  var ProgressoCapacitacao = $('#divGraficoCapacitacao').data('grafico');

  Highcharts.chart('divGraficoCapacitacao', {
    chart: {
      type: 'bar'
    },
    title: {
      text: ''
    },
    subtitle: {
      text: ''
    },
    xAxis: {
      categories: ProgressoCapacitacao.categories,
      crosshair: true
    },
    yAxis: {
      min: 0,
      title: {
        text: ''
      }
    },
    credits: {
      enabled: false
    },
    tooltip: {
      headerFormat: '<span style="font-size:10px">{point.key}</span><table>',
      pointFormat: '<tr><td style="color:{series.color};padding:0;font-weight:bolder;">{series.name}: </td>' +
          '<td style="padding:0"><b>{point.y:.0f} </b></td></tr>',
      footerFormat: '</table>',
      shared: true,
      useHTML: true
    },
    plotOptions: {

      bar: {
        dataLabels: {
          enabled: true
        }
      }
    },
    series: ProgressoCapacitacao.series,
  });
}

function GraficoChamadosTecnologicos() {
  var ProgressoChamadosTecnologicos = $('#divGraficoChamadosTecnologicos').data('grafico');

  Highcharts.chart('divGraficoChamadosTecnologicos', {
    chart: {
      type: 'column'
    },
    title: {
      text: ''
    },
    subtitle: {
      text: ''
    },
    xAxis: {
      categories: ProgressoChamadosTecnologicos.categories,
      crosshair: true
    },
    yAxis: {
      min: 0,
      title: {
        text: ''
      }
    },
    credits: {
      enabled: false
    },
    tooltip: {
      headerFormat: '<span style="font-size:10px">{point.key}</span><table>',
      pointFormat: '<tr><td style="color:{series.color};padding:0;font-weight:bolder;">{series.name}: </td>' +
          '<td style="padding:0"><b>{point.y:.0f} </b></td></tr>',
      footerFormat: '</table>',
      shared: true,
      useHTML: true
    },
    plotOptions: {

      column: {
        pointPadding: 0.2,
        borderWidth: 0,
        dataLabels: {
          enabled: true
        }
      }
    },
    series: ProgressoChamadosTecnologicos.series,
  });
}

function GraficoDisponibilidadeRedeFocoNegocialZero() {
  var ProgressoDisponibilidadeRedeFocoNegocialZero = $('#divGraficoDisponibilidadeRedeFocoNegocialZero').data('grafico');

  Highcharts.chart('divGraficoDisponibilidadeRedeFocoNegocialZero', {
    chart: {
      type: 'column'
    },
    title: {
      text: ''
    },
    subtitle: {
      text: ''
    },
    xAxis: {
      categories: ProgressoDisponibilidadeRedeFocoNegocialZero.categories,
      crosshair: true
    },
    yAxis: {
      min: 0,
      title: {
        text: ''
      }
    },
    credits: {
      enabled: false
    },
    tooltip: {
      headerFormat: '<span style="font-size:10px">{point.key}</span><table>',
      pointFormat: '<tr><td style="color:{series.color};padding:0;font-weight:bolder;">{series.name}: </td>' +
          '<td style="padding:0"><b>{point.y:.0f} </b></td></tr>',
      footerFormat: '</table>',
      shared: true,
      useHTML: true
    },
    plotOptions: {

      column: {
        pointPadding: 0.2,
        borderWidth: 0,
        dataLabels: {
          enabled: true
        }
      }
    },
    series: ProgressoDisponibilidadeRedeFocoNegocialZero.series,
  });
}

function GraficoIncidentesResolvidosPrazo() {
  var ProgressoIncidentesResolvidosPrazo = $('#divGraficoIncidentesResolvidosPrazo').data('grafico');

  Highcharts.chart('divGraficoIncidentesResolvidosPrazo', {
    chart: {
      type: 'bar'
    },
    title: {
      text: ''
    },
    subtitle: {
      text: ''
    },
    xAxis: {
      categories: ProgressoIncidentesResolvidosPrazo.categories,
      crosshair: true
    },
    yAxis: {
      min: 0,
      title: {
        text: ''
      }
    },
    credits: {
      enabled: false
    },
    tooltip: {
      headerFormat: '<span style="font-size:10px">{point.key}</span><table>',
      pointFormat: '<tr><td style="color:{series.color};padding:0;font-weight:bolder;">{series.name}: </td>' +
          '<td style="padding:0"><b>{point.y:.0f} </b></td></tr>',
      footerFormat: '</table>',
      shared: true,
      useHTML: true
    },
    plotOptions: {
      bar: {
        dataLabels: {
          enabled: true
        }
      }
    },
    series: ProgressoIncidentesResolvidosPrazo.series,
  });
}

function GraficoJornadaHoraExtra() {
  var ProgressoJornadaHoraExtra = $('#divGraficoJornadaHoraExtra').data('grafico');

  Highcharts.chart('divGraficoJornadaHoraExtra', {
    chart: {
      type: 'column'
    },
    title: {
      text: ''
    },
    subtitle: {
      text: ''
    },
    xAxis: {
      categories: ProgressoJornadaHoraExtra.categories,
      crosshair: true
    },
    yAxis: {
      min: 0,
      title: {
        text: ''
      }
    },
    credits: {
      enabled: false
    },
    tooltip: {
      headerFormat: '<span style="font-size:10px">{point.key}</span><table>',
      pointFormat: '<tr><td style="color:{series.color};padding:0;font-weight:bolder;">{series.name}: </td>' +
          '<td style="padding:0"><b>{point.y:.0f} </b></td></tr>',
      footerFormat: '</table>',
      shared: true,
      useHTML: true
    },
    plotOptions: {
      column: {
        pointPadding: 0.2,
        borderWidth: 0,
        dataLabels: {
          enabled: true
        }
      }
    },
    series: ProgressoJornadaHoraExtra.series,
  });
}

function GraficoMatrizConformidadeNCTS() {
  var ProgressoMatrizConformidadeNCTS = $('#divGraficoMatrizConformidadeNCTS').data('grafico');

  Highcharts.chart('divGraficoMatrizConformidadeNCTS', {
    chart: {
      type: 'bar'
    },
    title: {
      text: ''
    },
    subtitle: {
      text: ''
    },
    xAxis: {
      categories: ProgressoMatrizConformidadeNCTS.categories,
      crosshair: true
    },
    yAxis: {
      min: 0,
      title: {
        text: ''
      }
    },
    credits: {
      enabled: false
    },
    tooltip: {
      headerFormat: '<span style="font-size:10px">{point.key}</span><table>',
      pointFormat: '<tr><td style="color:{series.color};padding:0;font-weight:bolder;">{series.name}: </td>' +
          '<td style="padding:0"><b>{point.y:.0f} </b></td></tr>',
      footerFormat: '</table>',
      shared: true,
      useHTML: true
    },
    plotOptions: {

      bar: {
        dataLabels: {
          enabled: true
        }
      }
    },
    series: ProgressoMatrizConformidadeNCTS.series,
  });
}

function GraficoMudancasNormaisConcluidasPrazo() {
  var ProgressoMudancasNormaisConcluidasPrazo = $('#divGraficoMudancasNormaisConcluidasPrazo').data('grafico');

  Highcharts.chart('divGraficoMudancasNormaisConcluidasPrazo', {
    chart: {
      type: 'bar'
    },
    title: {
      text: ''
    },
    subtitle: {
      text: ''
    },
    xAxis: {
      categories: ProgressoMudancasNormaisConcluidasPrazo.categories,
      crosshair: true
    },
    yAxis: {
      min: 0,
      title: {
        text: ''
      }
    },
    credits: {
      enabled: false
    },
    tooltip: {
      headerFormat: '<span style="font-size:10px">{point.key}</span><table>',
      pointFormat: '<tr><td style="color:{series.color};padding:0;font-weight:bolder;">{series.name}: </td>' +
          '<td style="padding:0"><b>{point.y:.0f} </b></td></tr>',
      footerFormat: '</table>',
      shared: true,
      useHTML: true
    },
    plotOptions: {

      bar: {
        dataLabels: {
          enabled: true
        }
      }
    },
    series: ProgressoMudancasNormaisConcluidasPrazo.series,
  });
}

function GraficoSatisfacaoAtendimento() {
  var ProgressoSatisfacaoAtendimento = $('#divGraficoSatisfacaoAtendimento').data('grafico');

  Highcharts.chart('divGraficoSatisfacaoAtendimento', {
    chart: {
      type: 'bar'
    },
    title: {
      text: ''
    },
    subtitle: {
      text: ''
    },
    xAxis: {
      categories: ProgressoSatisfacaoAtendimento.categories,
      crosshair: true
    },
    yAxis: {
      min: 0,
      title: {
        text: ''
      }
    },
    credits: {
      enabled: false
    },
    tooltip: {
      headerFormat: '<span style="font-size:10px">{point.key}</span><table>',
      pointFormat: '<tr><td style="color:{series.color};padding:0;font-weight:bolder;">{series.name}: </td>' +
          '<td style="padding:0"><b>{point.y:.0f} </b></td></tr>',
      footerFormat: '</table>',
      shared: true,
      useHTML: true
    },
    plotOptions: {

      bar: {
        dataLabels: {
          enabled: true
        }
      }
    },
    series: ProgressoSatisfacaoAtendimento.series,
  });
}