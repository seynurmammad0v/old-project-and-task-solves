package az.code.models;

import lombok.Data;
import lombok.ToString;

import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name = "people")
@Data
@ToString
public class Person {
    @Id
    private Long id;
    String name;
    String surname;

}
