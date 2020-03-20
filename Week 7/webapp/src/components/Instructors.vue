<template>
  <div>

    <h1 class='section-heading'>Instructors</h1>
        <table>
            <thead>
                <tr>
                    <th>First Name</th>
                    <th>Last Name</th>
                    <th>Age</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="instructor in instructors" v-bind:key="instructor">
                    <td>{{ instructor.firstName }}</td>
                    <td>{{ instructor.lastName }}</td>
                    <td>{{ instructor.age }}</td>
                </tr>
            </tbody>
        </table>

  </div>
</template>

<script>
  export default {
    name: 'Instructors',
    table: 'Tables',
        mounted() {
            this.instructors = getInstructors()
        },
        data () {
            return {
                instructors: []
            }
        }
    }

    function getInstructors() {
        return JSON.parse(instructors)
    }

    var instructors = '[{"firstName": "Tony", "lastName": "Stark", "age": "48"}, {"firstName": "Steve", "lastName": "Rogers", "age": "93"}]'
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

</style>
