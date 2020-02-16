<template>
  <div>

    <h1 class='section-heading'>Students</h1>
        <table>
            <thead>
                <tr>
                    <th>Student ID</th>
                    <th>Email Address</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="student in students" v-bind:key="student">
                    <td>{{ student.id }}</td>
                    <td>{{ student.email }}</td>
                </tr>
            </tbody>
        </table>

  </div>
</template>

<script>
  export default {
    name: 'Students',
        table: 'Tables',
        mounted() {
            this.students = getStudents()
        },
        data () {
            return {
                students: []
            }
        }
    }

    function getStudents() {
        return JSON.parse(students)
    }

    var students = '[{"id": "Peter Parker", "email": "spiderman@avengers.gov"}, {"id": "Scott Lang", "email": "ant_man@avengers.gov"}]'
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

</style>
