new Vue({
    el: '#reactApp',
    data: {
        songs: [
            { song: '' },
        ],
        songTime:'',
    },
    mounted: function () {
        this.$nextTick(function () {
            setInterval(function () {
                
            }.bind(this), 1000)
        })
    },
})