function dataChart(data) {
    const ctx = document.getElementById('booleanChart');

   
    const labels = data.map(item => item.enqueuedTime);
    const chartData = data.map(item => item.value === 'Open' ? 1 : 0); 

    console.log(labels);
    console.log(chartData); 

    if (ctx) {
        new Chart(ctx, {
            type: 'bar',
            data: {
                labels: labels, // Use enqueuedTime as the labels
                datasets: [{
                    label: 'Open / Closed',
                    data: chartData, // Use the mapped data (1 for 'Open' and 0 for other values)
                    backgroundColor: chartData.map(value => value === 1 ? 'Green' : 'Red'), // Color based on value
                    borderColor: 'black',
                    borderWidth: 1
                }]
            },
            options: {
                scales: {
                    y: {
                        beginAtZero: true,
                        ticks: {
                            stepSize: 1,
                            callback: function (value) {
                                return value === 1 ? 'True' : (value === 0 ? 'False' : value);
                            }
                        }
                    }
                }
            }
        });
    }
}
